# Graphic_Editor

простой графический редактор.
Редактор имеет зону для рисования и панель для выбора инструментов (в произвольном виде)
 
Инструменты для рисования - обязательные: кривая линия (карандаш),  линия, прямоугольник, окружность. Остальные - по желанию.
Инструменты при рисовании используют заданные пользователем толщину и  цвета, соответственно:
 * Должен быть реализован контрол для выбора толщины линии.
 * Должен быть реализован контрол выбора основного цвета и цвета фона.
 
 Должны быть реализованы следующие возможности:
 * очистка зоны рисования
 * сохранение текущего рисунка в *.bmp файл (или другой формат изображения)
 * загрузка ранее сохраненного рисунка
 * отмена предыдущей операции рисования
 * Процедура инверсии. При выполнении цвет каждого пикселя инвертируется. 
 Операция обязательно должна выполняться в фоновом потоке, уведомляя редактор о сотоянии путем установки значения в ProgrssBar'е
