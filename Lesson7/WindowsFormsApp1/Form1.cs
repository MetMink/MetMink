//а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
//б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.Игрок должен получить это число за минимальное количество ходов.
//в) * Добавить кнопку «Отменить», которая отменяет последние ходы.Используйте обобщенный класс Stack.
// Вся логика игры должна быть реализована в классе с удвоителем.
//Студент: Камышанов Дмитрий


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Doubler doubler;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            doubler.Plus();
            UpdateInfo();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doubler = new Doubler();
            UpdateInfo();
            btnPlus.Enabled = true;
            btnMulti.Enabled = true;
            btnBack.Enabled = true;
            btnReset.Enabled = true;
            doubler.StartUpdater += UpdateInfo;

        }
        void UpdateInfo()
        {
            lblFinish.Text = doubler.Finish.ToString();
            lblCurrent.Text = doubler.Current.ToString();
            lblCount.Text = doubler.Count.ToString();
            lblMinCount.Text = doubler.MinCount.ToString();
            if (doubler.Count > doubler.MinCount)
            {
                lblMinCount.ForeColor = Color.Red;
            }
            else if (doubler.Count <= doubler.MinCount)
            {
                lblMinCount.ForeColor = Color.Black;
            }

            if (doubler.Current == doubler.Finish)
            {
                MessageBox.Show("Вы победили!", "Ура", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (doubler.Current > doubler.Finish)
            {
                MessageBox.Show("Перебор...!", "Упс", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            doubler.Multi();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            doubler.Reset();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            newToolStripMenuItem.PerformClick();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            doubler.Back();
        }
    }
}
