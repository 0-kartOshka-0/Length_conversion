using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Length_conversion
{
    public partial class Form2 : Form
    {
        int X;
        int Y;

        public Size FormSize
        {
            get
            {
                try
                {
                    X = Int32.Parse(textBox1.Text);
                    Y = Int32.Parse(textBox2.Text);

                    return new Size(X, Y);
                }
                catch
                {
                    X = 518;
                    Y = 236;

                    return new Size(X, Y);
                }
            }
        }
        public FormWindowState Maximizade
        {
            get
            {
                if (comboBox1.SelectedIndex == 3)
                {
                    return FormWindowState.Maximized;
                }
                else
                {
                    return FormWindowState.Normal;
                }
            }
        }
        public Point Point
        {
            get
            {
                int widthScreen = Screen.PrimaryScreen.WorkingArea.Width;
                int heightScreen = Screen.PrimaryScreen.WorkingArea.Height;

                //по центру
                if (comboBox1.SelectedIndex == 0)
                {
                    return new Point(widthScreen / 2 - X / 2, heightScreen / 2 - Y / 2);
                }

                //центр сверху
                if (comboBox1.SelectedIndex == 1)
                {
                    return new Point(widthScreen / 2 - X / 2, 0);
                }

                //центр снизу
                if (comboBox1.SelectedIndex == 2)
                {
                    return new Point(widthScreen / 2 - X / 2, heightScreen - Y);
                }
                else
                    return new Point(0, 0);
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.BackColor = label4.BackColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            label4.BackColor = colorDialog1.Color;
        }
    }
}
