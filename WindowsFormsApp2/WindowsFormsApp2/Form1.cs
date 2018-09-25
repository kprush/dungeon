using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x == 1)
            {
                randdom();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = 1;
        }
        private void randdom()
        {
            Random random = new Random();
            int num = random.Next(0, 26);
            char let = (char)('a' + num);
            textBox1.Text += let;
            num = random.Next(1, 13);
            switch (num)
            {
                case 1:
                    radioButton1.Checked = true;
                    break;
                case 2:
                    radioButton2.Checked = true;
                    break;
                case 3:
                    radioButton3.Checked = true;
                    break;
                case 4:
                    radioButton4.Checked = true;
                    break;
                case 5:
                    radioButton5.Checked = true;
                    break;
                case 6:
                    radioButton6.Checked = true;
                    break;
                case 7:
                    radioButton7.Checked = true;
                    break;
                case 12:
                    radioButton12.Checked = true;
                    break;
                case 11:
                    radioButton11.Checked = true;
                    break;
                case 10:
                    radioButton10.Checked = true;
                    break;
                case 9:
                    radioButton9.Checked = true;
                    break;
                case 8:
                    radioButton8.Checked = true;
                    break;

            }
            Random gen = new Random();
            DateTime start = new DateTime(1753, 1, 1);
            int range = (DateTime.Today - start).Days;
            dateTimePicker1.Value = start.AddDays(gen.Next(range));
            num = random.Next(0, 256);
            hScrollBar1.Value = num;
            num = random.Next(0, 256);
            hScrollBar2.Value = num;
            num = random.Next(0, 256);
            hScrollBar3.Value = num;
            panel2.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            num = random.Next(1, 29);
            switch (num) {
                case 1:
                    Cursor.Current = Cursors.AppStarting;
                    break;
                case 2:
                    Cursor.Current = Cursors.Arrow;
                    break;
                case 3:
                    Cursor.Current = Cursors.Cross;
                    break;
                case 4:
                    Cursor.Current = Cursors.Default;
                    break;
                case 5:
                    Cursor.Current = Cursors.Hand;
                    break;
                case 6:
                    Cursor.Current = Cursors.Help;
                    break;
                case 7:
                    Cursor.Current = Cursors.HSplit;
                    break;
                case 8:
                    Cursor.Current = Cursors.IBeam;
                    break;
                case 9:
                    Cursor.Current = Cursors.No;
                    break;
                case 10:
                    Cursor.Current = Cursors.NoMove2D;
                    break;
                case 11:
                    Cursor.Current = Cursors.NoMoveHoriz;
                    break;
                case 12:
                    Cursor.Current = Cursors.NoMoveVert;
                    break;

                case 13:
                    Cursor.Current = Cursors.PanEast;
                    break;
                case 14:
                    Cursor.Current = Cursors.PanNE;
                    break;
                case 15:
                    Cursor.Current = Cursors.PanNorth;
                    break;
                case 16:
                    Cursor.Current = Cursors.PanNW;
                    break;

                case 17:
                    Cursor.Current = Cursors.PanSE;
                    break;
                case 18:
                    Cursor.Current = Cursors.PanSouth;
                    break;
                case 19:
                    Cursor.Current = Cursors.PanSW;
                    break;
                case 20:
                    Cursor.Current = Cursors.PanWest;
                    break;
                case 21:
                    Cursor.Current = Cursors.SizeAll;
                    break;
                case 22:
                    Cursor.Current = Cursors.SizeNESW;
                    break;
                case 23:
                    Cursor.Current = Cursors.SizeNS;
                    break;
                case 24:
                    Cursor.Current = Cursors.SizeNWSE;
                    break;
                case 25:
                    Cursor.Current = Cursors.SizeWE;
                    break;
                case 26:
                    Cursor.Current = Cursors.UpArrow;
                    break;
                case 27:
                    Cursor.Current = Cursors.VSplit;
                    break;
                case 28:
                    Cursor.Current = Cursors.WaitCursor;
                    break;

            }
            num = random.Next(800, 1920);
            this.Width = num;
            num = random.Next(287, 1080);
            this.Height = num;
            Application application = Application.Launch("note.exe");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.F))
            {
                System.Windows.Forms.Application.Exit();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
