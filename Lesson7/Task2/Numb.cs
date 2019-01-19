//Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток.
//Компьютер говорит, больше или меньше загаданное число введенного.
//a) Для ввода данных от человека используется элемент TextBox;
//б) ** Реализовать отдельную форму c TextBox для ввода числа.
//Студент Камышанов Дмитрий


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    class Numb
    {
        int num;
        int myNum;
        int count;

        public int Num => num;
        public int MyNum => myNum;
        public int Count => count;

        public Numb()
        {
            Random rnd = new Random();
            num = rnd.Next(1, 100);
            count = 0;
        }
        public void Try(int MyNum)
        {
            if (MyNum > 100 && MyNum < 1)
            {
                MessageBox.Show("Введенное число вне диапазона, но попытка засчитана)");
                count++;
            }
            else if (MyNum == num)
            {
                MessageBox.Show("Вы угадали!");
            }
           else if(MyNum > num)
            {
                MessageBox.Show("Ваше число больше загаданного");
                count++;
            }
            else if (MyNum < num)
            {
                MessageBox.Show("Ваше число меньше загаданного");
                count++;
            }
        }
    }
}
