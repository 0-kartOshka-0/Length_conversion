using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double m = 0;
        private bool show = false;

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                return;
            if (e.KeyChar == ',')
            {
                var textbox = sender as TextBox;
                if (textbox.Text.Contains(','))
                    e.Handled = true;
                return;
            }
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
                return;
            e.Handled = true;
        }
        private void метрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Enabled = true;
            try
            {
                if (sender == метрыToolStripMenuItem)
                {
                    label3.Text = "метры";
                    m = double.Parse(textBox1.Text);
                }
                    
                else if (sender == вершокToolStripMenuItem)
                {
                    label3.Text = "вершки";
                    m = double.Parse(textBox1.Text) / 44.45;
                }
                else if (sender == аршинToolStripMenuItem)
                {
                    label3.Text = "аршины";
                    m = double.Parse(textBox1.Text) / 0.7112;
                }  
                else if (sender == саженьToolStripMenuItem)
                {
                    label3.Text = "сажени";
                    m = double.Parse(textBox1.Text) / 1.905;
                }
                else if (sender == верстаToolStripMenuItem)
                {
                    label3.Text = "версты";
                    m = double.Parse(textBox1.Text) / 0.007;
                }
                else
                    label3.Text = "";
            }
            catch
            {
                MessageBox.Show("Введены некорректные данные.");
                toolStrip1.Enabled = false;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                double result = 0;
                if (sender == toolStripButton1)
                {
                   label4.Text = "метры";
                    result = m;
                }
                else if (sender == toolStripButton2)
                {
                   label4.Text = "вершки";
                    result = m * 44.45;
                }
                else if (sender == toolStripButton3)
                {
                   label4.Text = "сажени";
                    result = m * 1.905;
                }
                else if (sender == toolStripButton4)
                {
                   label4.Text = "аршины";
                    result = m * 0.7112;
                }
                else if (sender == toolStripButton5)
                {
                   label4.Text = "версты";
                    result = m * 0.007;
                }
                textBox2.Text = ("" + result);
                //toolStrip1.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Введены некорректные данные.");
            }
        }

        private void текстКнопкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (show)
            {
                toolStrip1.Visible = true;
                show = false;
            }
            else
            {
                toolStrip1.Visible = false;
                show = true;
            }
        }
        private void настройкаИнтерфейсаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Owner = this;
            form2.ShowDialog();

            this.Size = form2.FormSize;
            this.WindowState = form2.Maximizade;
            this.Location = form2.Point;
            //this.Color = form2.Point;
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.Owner = this;
            aboutBox1.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
