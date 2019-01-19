using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        Numb numb;
        int i;
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            numb = new Numb();
        }

        private void textBox_MyText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                i = Convert.ToInt32(textBox_MyText.Text);
                
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong format");
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            newToolStripMenuItem.PerformClick();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            numb.Try(i);
            string g = (i.ToString() + "\r\n");
            textBox_Tries.Text += g;
            if (numb.Count > 6)
            {
                MessageBox.Show("Превышено максимальное количество попыток. Игра начинается сначала");
                newToolStripMenuItem.PerformClick();
                textBox_Tries.Clear();
            }
        }
    }
}
