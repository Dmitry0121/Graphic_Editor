namespace MyGraphicEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripMainMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripBasicTools = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPencil = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRectangle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEllipse = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEraser = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxSizeLine = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxFill = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButtonInversion = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonText = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBoxEnterText = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBoxSizeFont = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBoxChooseFont = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonBaseColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonBackgroundColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonChooseColor = new System.Windows.Forms.ToolStripButton();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.pictureBoxWorkZone = new System.Windows.Forms.PictureBox();
            this.progressBarInversion = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.toolStripMainMenu.SuspendLayout();
            this.toolStripBasicTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWorkZone)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMainMenu
            // 
            this.toolStripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNew,
            this.toolStripButtonOpen,
            this.toolStripButtonSave,
            this.toolStripButtonUndo});
            this.toolStripMainMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMainMenu.Name = "toolStripMainMenu";
            this.toolStripMainMenu.Size = new System.Drawing.Size(1034, 25);
            this.toolStripMainMenu.TabIndex = 52;
            this.toolStripMainMenu.Text = "toolStrip1";
            // 
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNew.Image = global::MyGraphicEditor.Properties.Resources._new;
            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNew.Text = "new";
            this.toolStripButtonNew.Click += new System.EventHandler(this.toolStripButtonNew_Click);
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpen.Image = global::MyGraphicEditor.Properties.Resources.open;
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOpen.Text = "open";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = global::MyGraphicEditor.Properties.Resources.save;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSave.Text = "save";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButtonUndo
            // 
            this.toolStripButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUndo.Image = global::MyGraphicEditor.Properties.Resources.undo;
            this.toolStripButtonUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUndo.Name = "toolStripButtonUndo";
            this.toolStripButtonUndo.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUndo.Text = "undo";
            this.toolStripButtonUndo.Click += new System.EventHandler(this.toolStripButtonUndo_Click);
            // 
            // toolStripBasicTools
            // 
            this.toolStripBasicTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPencil,
            this.toolStripButtonLine,
            this.toolStripButtonRectangle,
            this.toolStripButtonEllipse,
            this.toolStripButtonEraser,
            this.toolStripLabel4,
            this.toolStripComboBoxSizeLine,
            this.toolStripLabel5,
            this.toolStripComboBoxFill,
            this.toolStripButtonInversion,
            this.toolStripSeparator1,
            this.toolStripButtonText,
            this.toolStripTextBoxEnterText,
            this.toolStripComboBoxSizeFont,
            this.toolStripComboBoxChooseFont,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.toolStripButtonBaseColor,
            this.toolStripLabel2,
            this.toolStripButtonBackgroundColor,
            this.toolStripLabel3,
            this.toolStripButtonChooseColor});
            this.toolStripBasicTools.Location = new System.Drawing.Point(0, 25);
            this.toolStripBasicTools.Name = "toolStripBasicTools";
            this.toolStripBasicTools.Size = new System.Drawing.Size(1034, 25);
            this.toolStripBasicTools.TabIndex = 53;
            this.toolStripBasicTools.Text = "toolStrip2";
            // 
            // toolStripButtonPencil
            // 
            this.toolStripButtonPencil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPencil.Image = global::MyGraphicEditor.Properties.Resources.pencil;
            this.toolStripButtonPencil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPencil.Name = "toolStripButtonPencil";
            this.toolStripButtonPencil.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPencil.Text = "pencil";
            this.toolStripButtonPencil.Click += new System.EventHandler(this.toolStripButtonPencil_Click);
            // 
            // toolStripButtonLine
            // 
            this.toolStripButtonLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLine.Image = global::MyGraphicEditor.Properties.Resources.line;
            this.toolStripButtonLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLine.Name = "toolStripButtonLine";
            this.toolStripButtonLine.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonLine.Text = "line";
            this.toolStripButtonLine.Click += new System.EventHandler(this.toolStripButtonLine_Click);
            // 
            // toolStripButtonRectangle
            // 
            this.toolStripButtonRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRectangle.Image = global::MyGraphicEditor.Properties.Resources.rectangle;
            this.toolStripButtonRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRectangle.Name = "toolStripButtonRectangle";
            this.toolStripButtonRectangle.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRectangle.Text = "rectangle";
            this.toolStripButtonRectangle.Click += new System.EventHandler(this.toolStripButtonRectangle_Click);
            // 
            // toolStripButtonEllipse
            // 
            this.toolStripButtonEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEllipse.Image = global::MyGraphicEditor.Properties.Resources.circle;
            this.toolStripButtonEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEllipse.Name = "toolStripButtonEllipse";
            this.toolStripButtonEllipse.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEllipse.Text = "ellipse";
            this.toolStripButtonEllipse.Click += new System.EventHandler(this.toolStripButtonEllipse_Click);
            // 
            // toolStripButtonEraser
            // 
            this.toolStripButtonEraser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEraser.Image = global::MyGraphicEditor.Properties.Resources.eraser;
            this.toolStripButtonEraser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEraser.Name = "toolStripButtonEraser";
            this.toolStripButtonEraser.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEraser.Text = "eraser";
            this.toolStripButtonEraser.Click += new System.EventHandler(this.toolStripButtonEraser_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(62, 22);
            this.toolStripLabel4.Text = "Толщина:";
            // 
            // toolStripComboBoxSizeLine
            // 
            this.toolStripComboBoxSizeLine.Items.AddRange(new object[] {
            "1",
            "2",
            "4"});
            this.toolStripComboBoxSizeLine.Name = "toolStripComboBoxSizeLine";
            this.toolStripComboBoxSizeLine.Size = new System.Drawing.Size(75, 25);
            this.toolStripComboBoxSizeLine.Text = "1";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(55, 22);
            this.toolStripLabel5.Text = "Заливка:";
            // 
            // toolStripComboBoxFill
            // 
            this.toolStripComboBoxFill.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.toolStripComboBoxFill.Name = "toolStripComboBoxFill";
            this.toolStripComboBoxFill.Size = new System.Drawing.Size(75, 25);
            this.toolStripComboBoxFill.Text = "Нет";
            // 
            // toolStripButtonInversion
            // 
            this.toolStripButtonInversion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonInversion.Image = global::MyGraphicEditor.Properties.Resources.inversion;
            this.toolStripButtonInversion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInversion.Name = "toolStripButtonInversion";
            this.toolStripButtonInversion.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonInversion.Text = "inversion";
            this.toolStripButtonInversion.Click += new System.EventHandler(this.toolStripButtonInversion_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonText
            // 
            this.toolStripButtonText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonText.Image = global::MyGraphicEditor.Properties.Resources.text;
            this.toolStripButtonText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonText.Name = "toolStripButtonText";
            this.toolStripButtonText.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonText.Text = "text";
            this.toolStripButtonText.Click += new System.EventHandler(this.toolStripButtonText_Click);
            // 
            // toolStripTextBoxEnterText
            // 
            this.toolStripTextBoxEnterText.Name = "toolStripTextBoxEnterText";
            this.toolStripTextBoxEnterText.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBoxEnterText.Text = "Текст";
            // 
            // toolStripComboBoxSizeFont
            // 
            this.toolStripComboBoxSizeFont.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "28",
            "36",
            "48",
            "72"});
            this.toolStripComboBoxSizeFont.Name = "toolStripComboBoxSizeFont";
            this.toolStripComboBoxSizeFont.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBoxSizeFont.Text = "12";
            // 
            // toolStripComboBoxChooseFont
            // 
            this.toolStripComboBoxChooseFont.Name = "toolStripComboBoxChooseFont";
            this.toolStripComboBoxChooseFont.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBoxChooseFont.Text = "Calibri";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabel1.Text = "Цвет 1:";
            // 
            // toolStripButtonBaseColor
            // 
            this.toolStripButtonBaseColor.BackColor = System.Drawing.Color.Black;
            this.toolStripButtonBaseColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBaseColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBaseColor.Name = "toolStripButtonBaseColor";
            this.toolStripButtonBaseColor.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonBaseColor.Click += new System.EventHandler(this.toolStripButtonColorBase_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabel2.Text = "Цвет 2:";
            // 
            // toolStripButtonBackgroundColor
            // 
            this.toolStripButtonBackgroundColor.BackColor = System.Drawing.Color.White;
            this.toolStripButtonBackgroundColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBackgroundColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBackgroundColor.Name = "toolStripButtonBackgroundColor";
            this.toolStripButtonBackgroundColor.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonBackgroundColor.Click += new System.EventHandler(this.toolStripButtonColorBackground_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(57, 22);
            this.toolStripLabel3.Text = "Выбрать:";
            // 
            // toolStripButtonChooseColor
            // 
            this.toolStripButtonChooseColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonChooseColor.Image = global::MyGraphicEditor.Properties.Resources.color;
            this.toolStripButtonChooseColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonChooseColor.Name = "toolStripButtonChooseColor";
            this.toolStripButtonChooseColor.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonChooseColor.Text = "color";
            this.toolStripButtonChooseColor.Click += new System.EventHandler(this.toolStripButtonChooseColor_Click);
            // 
            // pictureBoxWorkZone
            // 
            this.pictureBoxWorkZone.BackColor = System.Drawing.Color.White;
            this.pictureBoxWorkZone.InitialImage = null;
            this.pictureBoxWorkZone.Location = new System.Drawing.Point(6, 53);
            this.pictureBoxWorkZone.Name = "pictureBoxWorkZone";
            this.pictureBoxWorkZone.Size = new System.Drawing.Size(1024, 607);
            this.pictureBoxWorkZone.TabIndex = 28;
            this.pictureBoxWorkZone.TabStop = false;
            this.pictureBoxWorkZone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxWorkZone_MouseClick);
            this.pictureBoxWorkZone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxWorkZone_MouseDown);
            this.pictureBoxWorkZone.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxWorkZone_MouseMove);
            this.pictureBoxWorkZone.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxWorkZone_MouseUp);
            // 
            // progressBarInversion
            // 
            this.progressBarInversion.Location = new System.Drawing.Point(102, -1);
            this.progressBarInversion.Name = "progressBarInversion";
            this.progressBarInversion.Size = new System.Drawing.Size(932, 23);
            this.progressBarInversion.TabIndex = 54;
            this.progressBarInversion.Visible = false;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork_InverseImage);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged_InverseImage);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted_InverseImage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 661);
            this.Controls.Add(this.progressBarInversion);
            this.Controls.Add(this.toolStripBasicTools);
            this.Controls.Add(this.toolStripMainMenu);
            this.Controls.Add(this.pictureBoxWorkZone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graphic Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripMainMenu.ResumeLayout(false);
            this.toolStripMainMenu.PerformLayout();
            this.toolStripBasicTools.ResumeLayout(false);
            this.toolStripBasicTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWorkZone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxWorkZone;
        private System.Windows.Forms.ToolStrip toolStripMainMenu;
        private System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStrip toolStripBasicTools;
        private System.Windows.Forms.ToolStripButton toolStripButtonPencil;
        private System.Windows.Forms.ToolStripButton toolStripButtonLine;
        private System.Windows.Forms.ToolStripButton toolStripButtonRectangle;
        private System.Windows.Forms.ToolStripButton toolStripButtonEllipse;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonText;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxEnterText;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxSizeFont;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxChooseFont;
        private System.Windows.Forms.ToolStripButton toolStripButtonInversion;
        private System.Windows.Forms.ToolStripButton toolStripButtonEraser;
        private System.Windows.Forms.ToolStripButton toolStripButtonBaseColor;
        private System.Windows.Forms.ToolStripButton toolStripButtonBackgroundColor;
        private System.Windows.Forms.ToolStripButton toolStripButtonChooseColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxSizeLine;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButtonUndo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ProgressBar progressBarInversion;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFill;
    }
}

