using System.Windows.Forms;


namespace Twitalica
{
    public partial class FormMain : Form
    {
        private void dragForm_begin()
        {
            OldPos = this.Location;
            OldMousePosition = MousePosition;
            Dragging = true;
        }
        private void dragForm_move()
        {
            if (Dragging)
            {
                NewPos.X = OldPos.X + (MousePosition.X - OldMousePosition.X);
                NewPos.Y = OldPos.Y + (MousePosition.Y - OldMousePosition.Y);
                this.Location = NewPos;
                OldPos = this.Location;
                OldMousePosition = MousePosition;
            }
        }
        private void dragForm_end()
        {
            Dragging = false;
        }
        private void labelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            dragForm_begin();
        }
        private void labelTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            dragForm_move();
        }
        private void labelTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            dragForm_end();
        }
        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            dragForm_begin();
        }
        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            dragForm_move();
        }
        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            dragForm_end();
        }

    }
}
