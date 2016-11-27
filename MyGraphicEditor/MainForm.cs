using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using MyGraphicEditor.Enums;

namespace MyGraphicEditor
{
    public partial class MainForm : Form
    {
        private Color paintColorBase = Color.Black;
        private Color paintColorBackground = Color.White;
        private bool isPaintColorSelected = true;
        private Bitmap bitmapForInverseImage;
        private Bitmap bm;
        private Point currPoint;
        private Point prevPoint;
        private int x, y;
        private PaintToolsEnum currItem;
        private List<Bitmap> stackBm;

        private const string YES_ANSWER = "Да";
        private const string IMAGE_FILTER = "PNG (*.png)|*.png|JPEG (*.jpg;*.jpeg;*.jpe;*.jfif)|*jpg|Точечный рисунок (*.bmp;*.dib)|*.bmp";

        public MainForm()
        {
            InitializeComponent();
            bm = new Bitmap(1024, 607);
            stackBm = new List<Bitmap>();
            stackBm.Add(new Bitmap(bm));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FontFamily[] family = FontFamily.Families;
            foreach (FontFamily font in family)
            {
                toolStripComboBoxChooseFont.Items.Add(font.GetName(1));
            }
            currItem = PaintToolsEnum.Pencil;
        }

        #region Facilities

        private void pictureBoxWorkZone_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                AddBitmapToList(bm);

                currPoint = e.Location;
                x = e.X;
                y = e.Y;
            }
        }

        private void pictureBoxWorkZone_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pictureBoxWorkZone.Image = bm;

                int x1 = x < e.X ? x : e.X;
                int x2 = x > e.X ? x : e.X;
                int y1 = y < e.Y ? y : e.Y;
                int y2 = y > e.Y ? y : e.Y;

                Rectangle rectanglePositionDraw = new Rectangle(x, y, e.X - x, e.Y - y);

                using (var g = Graphics.FromImage(bm))
                {
                    switch (currItem)
                    {
                        case PaintToolsEnum.Rectangle:
                            if (toolStripComboBoxFill.Text == YES_ANSWER)
                            {
                                g.FillRectangle(new SolidBrush(paintColorBase), x1, y1, x2 - x1, y2 - y1);
                            }
                            else
                            {
                                g.DrawRectangle(new Pen(paintColorBase,
                                    Convert.ToInt32(toolStripComboBoxSizeLine.Text)), rectanglePositionDraw);
                            }
                            break;

                        case PaintToolsEnum.Ellipse:
                            if (toolStripComboBoxFill.Text == YES_ANSWER)
                            {
                                g.FillEllipse(new SolidBrush(paintColorBase), x1, y1, x2 - x1, y2 - y1);
                            }
                            else
                            {
                                g.DrawEllipse(new Pen(paintColorBase,
                                    Convert.ToInt32(toolStripComboBoxSizeLine.Text)), rectanglePositionDraw);
                            }
                            break;

                        case PaintToolsEnum.Line:
                            prevPoint = currPoint;
                            currPoint = e.Location;
                            g.DrawLine(new Pen(paintColorBase,
                                Convert.ToInt32(toolStripComboBoxSizeLine.Text)), currPoint, prevPoint);
                            break;
                    }
                }
            }
        }

        private void pictureBoxWorkZone_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pictureBoxWorkZone.Image = bm;

                using (var g = Graphics.FromImage(bm))
                {
                    if (currItem == PaintToolsEnum.Text)
                    {
                        g.DrawString(toolStripTextBoxEnterText.Text, new Font(toolStripComboBoxChooseFont.Text,
                            Convert.ToInt32(toolStripComboBoxSizeFont.Text), FontStyle.Regular),
                            new SolidBrush(paintColorBase), new PointF(x, y));
                    }
                }
            }
        }

        private void pictureBoxWorkZone_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pictureBoxWorkZone.Image = bm;

                using (var g = Graphics.FromImage(bm))
                {
                    switch (currItem)
                    {
                        case PaintToolsEnum.Pencil:
                            prevPoint = currPoint;
                            currPoint = e.Location;
                            g.DrawLine(new Pen(paintColorBase,
                                Convert.ToInt32(toolStripComboBoxSizeLine.Text)), currPoint, prevPoint);
                            break;

                        case PaintToolsEnum.Eraser:
                            g.FillRectangle(new SolidBrush(paintColorBackground), e.X, e.Y,
                                          (Convert.ToInt32(toolStripComboBoxSizeLine.Text) * 5),
                                          Convert.ToInt32(toolStripComboBoxSizeLine.Text) * 5);
                            break;
                    }
                }
            }
        }
            
        private void toolStripButtonUndo_Click(object sender, EventArgs e)
        {
            if (stackBm.Any())
            {
                bm = stackBm[stackBm.Count - 1];
                stackBm.RemoveAt(stackBm.Count - 1);
                
                pictureBoxWorkZone.Image = bm;
            }
        }

        private void backgroundWorker_DoWork_InverseImage(object sender, DoWorkEventArgs e)
        {
            pictureBoxWorkZone.Image = bm;

            AddBitmapToList(bm);

            BackgroundWorker worker = sender as BackgroundWorker;

            if (worker != null)
            {
                bitmapForInverseImage = (Bitmap)pictureBoxWorkZone.Image.Clone();

                byte A, R, G, B;
                Color pixelColor;

                for (int i = 0; i < bitmapForInverseImage.Height; i++)
                {
                    worker.ReportProgress(i);
                    for (int j = 0; j < bitmapForInverseImage.Width; j++)
                    {
                        pixelColor = bitmapForInverseImage.GetPixel(j, i);
                        A = pixelColor.A;
                        R = pixelColor.R;
                        G = pixelColor.G;
                        B = pixelColor.B;
                        bitmapForInverseImage.SetPixel(j, i, Color.FromArgb(A, 0xFF - R, 0xFF - G, 0xFF - B));
                    }
                }
            }
        }

        private void backgroundWorker_ProgressChanged_InverseImage(object sender, ProgressChangedEventArgs e)
        {
            progressBarInversion.Value = e.ProgressPercentage;
        }

        private void backgroundWorker_RunWorkerCompleted_InverseImage(object sender, RunWorkerCompletedEventArgs e)
        {
            bm = bitmapForInverseImage;
            progressBarInversion.Visible = false;
        }

        #endregion

        #region Tools 

        private void toolStripButtonPencil_Click(object sender, EventArgs e)
        {
            currItem = PaintToolsEnum.Pencil;
        }

        private void toolStripButtonLine_Click(object sender, EventArgs e)
        {
            currItem = PaintToolsEnum.Line;
        }

        private void toolStripButtonRectangle_Click(object sender, EventArgs e)
        {
            currItem = PaintToolsEnum.Rectangle;
        }

        private void toolStripButtonEllipse_Click(object sender, EventArgs e)
        {
            currItem = PaintToolsEnum.Ellipse;
        }

        private void toolStripButtonEraser_Click(object sender, EventArgs e)
        {
            currItem = PaintToolsEnum.Eraser;
        }

        private void toolStripButtonText_Click(object sender, EventArgs e)
        {
            currItem = PaintToolsEnum.Text;
        }

        private void toolStripButtonInversion_Click(object sender, EventArgs e)
        {
            progressBarInversion.Visible = true;
            progressBarInversion.Minimum = 0;
            progressBarInversion.Maximum = pictureBoxWorkZone.Height + 1;
            backgroundWorker.RunWorkerAsync();
        }

        #endregion

        #region Menu

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            SaveImage();
            pictureBoxWorkZone.Refresh();
            pictureBoxWorkZone.Image = null;
            bm = new Bitmap(1024, 607);
            stackBm.Clear();
        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            pictureBoxWorkZone.Refresh();
            pictureBoxWorkZone.Image = null;
            stackBm.Clear();

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = IMAGE_FILTER;

            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBoxWorkZone.Width = (Image.FromFile(open.FileName).Width);
                pictureBoxWorkZone.Height = (Image.FromFile(open.FileName).Height);
                bm = (Bitmap)Image.FromFile(open.FileName).Clone();
            }
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            SaveImage();
        }
        
        #endregion

        #region Color

        private void toolStripButtonChooseColor_Click(object sender, EventArgs e)
        {
            DialogResult dialog = colorDialog.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                if (isPaintColorSelected)
                {
                    paintColorBase = colorDialog.Color;
                    toolStripButtonBaseColor.BackColor = colorDialog.Color;
                }
                else
                {
                    paintColorBackground = colorDialog.Color;
                    toolStripButtonBackgroundColor.BackColor = colorDialog.Color;
                }
            }
        }

        private void toolStripButtonColorBackground_Click(object sender, EventArgs e)
        {
            isPaintColorSelected = false;
        }

        private void toolStripButtonColorBase_Click(object sender, EventArgs e)
        {
            isPaintColorSelected = true;
        }

        #endregion
        
        #region MyMethods

        private void AddBitmapToList(Bitmap bm)
        {
            if (stackBm.Count > 20)
            {
                stackBm.RemoveAt(0);
            }

            stackBm.Add(new Bitmap(bm));
        }

        private void SaveImage()
        {
            Bitmap saveImg = new Bitmap(pictureBoxWorkZone.Width, pictureBoxWorkZone.Height);

            using (Graphics g = Graphics.FromImage(saveImg))
            {
                Rectangle rect = pictureBoxWorkZone.RectangleToScreen(pictureBoxWorkZone.ClientRectangle);
                g.CopyFromScreen(rect.Location, Point.Empty, pictureBoxWorkZone.Size);
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = IMAGE_FILTER;
            if (save.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(save.FileName))
                {
                    File.Delete(save.FileName);
                }
                if (save.FileName.Contains(".jpg"))
                {
                    saveImg.Save(save.FileName, ImageFormat.Jpeg);
                }
                else if (save.FileName.Contains(".png"))
                {
                    saveImg.Save(save.FileName, ImageFormat.Png);
                }
                else if (save.FileName.Contains(".bmp"))
                {
                    saveImg.Save(save.FileName, ImageFormat.Bmp);
                }
            }
        }

        #endregion
    }
}
