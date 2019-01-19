//Написать метод, возвращающий минимальное из трёх чисел.


using Routinely;
using System;

namespace homework
{
    public partial class Tasks
    {
        public static double min()
        {
            double a, b, c;
            double min = 0;
            Ez.Print("Введите первое число:");
            a = Ez.EnterDouble();
            Ez.Print("Введите второе число:");
            b = Ez.EnterDouble();
            Ez.Print("Введите третье число:");
            c = Ez.EnterDouble();
            if (a < b && a < c)
            {
                min = a;
            }
            else if (b < a && b < c)
            {
                min = b;
            }
            else if (c < a && c < b)
            {
                min = c;
            }
            return min;
        }
    }
}