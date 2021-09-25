using System;
using System.Drawing;
using System.Windows.Forms;

namespace Twitalica
{
    public partial class FormMain : Form
    {
        public Point OldPos;
        public Point NewPos;
        public Point OldMousePosition;
        bool Dragging;

        const int MAX_CHARS = 280;
        int Remaining;

        public FormMain()
        {
            InitializeComponent();
            
            Modified = "";
            labelBytes.Text = String.Format("{0:d3}:({1:d3})", Modified.Length, Remaining);
            panelCommands.Hide();
            panelUI.BringToFront();
            radioScript.Enabled = false;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            radioItalic.Checked = true;
            ModifiedAlphabet = ITALIC_ALPHA;
            textBoxIn.Focus();
        }
        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                panelUI.Hide();
                panelCommands.Show();
                textBoxIn.Enabled = false;
                switch (e.KeyCode)
                {
                    case Keys.Q:
                        this.Close();
                        break;
                    case Keys.Enter:
                    case Keys.C:
                    case Keys.Insert:
                        if (Modified.Length == 0)
                            Clipboard.Clear();
                        else Clipboard.SetText(Modified);
                        break;
                }
            }
        }
        private void FormMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (!e.Control)
            {
                textBoxIn.Enabled = true;
                textBoxIn.Focus();
                panelCommands.Hide();
                panelUI.Show();
            }
        }
        private void textBoxIn_TextChanged(object sender, EventArgs e)
        {
            Modified = textBoxIn.Text;
            Remaining = MAX_CHARS - Modified.Length;
            labelBytes.Text = String.Format("{0:d3}:({1:d3})", Modified.Length, Remaining);
            if (Remaining < 0)
                labelBytes.ForeColor = Color.Red;
            else
                labelBytes.ForeColor = Color.Black;
        }
        private void radioItalic_CheckedChanged(object sender, EventArgs e)
        {
            ModifiedAlphabet = ITALIC_ALPHA;
            Modified = textBoxIn.Text;
        }
        private void radioBold_CheckedChanged(object sender, EventArgs e)
        {
            ModifiedAlphabet = BOLD_ALPHA;
            Modified = textBoxIn.Text;
        }
        private void radioItBo_CheckedChanged(object sender, EventArgs e)
        {
            ModifiedAlphabet = ITBO_ALPHA;
            Modified = textBoxIn.Text;
        }
        private void radioScript_CheckedChanged(object sender, EventArgs e)
        {
            ModifiedAlphabet = SCRIPT_ALPHA;
            Modified = textBoxIn.Text;
        }
        private void radioScrBo_CheckedChanged(object sender, EventArgs e)
        {
            ModifiedAlphabet = SCRBO_ALPHA;
            Modified = textBoxIn.Text;
        }
        private void radioBlackletter_CheckedChanged(object sender, EventArgs e)
        {
            ModifiedAlphabet = BLACKLETTER_ALPHA;
            Modified = textBoxIn.Text;
        }
        private void radioBlaBo_CheckedChanged(object sender, EventArgs e)
        {
            ModifiedAlphabet = BLABO_ALPHA;
            Modified = textBoxIn.Text;
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            textBoxIn.Focus();
        }
        private void buttonTopMost_Click(object sender, EventArgs e)
        {
            if (TopMost)
            {
                TopMost = false;
                buttonTopMost.BackColor = Color.FromArgb(255, 0, 95, 191);
            }
            else
            {
                TopMost = true;
                buttonTopMost.BackColor = Color.FromArgb(255, 200, 255, 255);
            }
            textBoxIn.Focus();
        }
    }
}
