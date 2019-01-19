//С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечётных положительных чисел. Студент: Камышанов Дмитрий
using System;
using Routinely;

namespace homework
{
   public partial class Tasks
    {
        public static int SumOfNums ()
        {
            int sum = 0;
            Ez.Print("Вводите числа");
            do
            {
                int i = Ez.EnterInt();
                if (i % 2 == 1 && i > 0)
                {
                    sum += i;
                }
                else if (i == 0)
                {
                    break;
                }
            }
            while (true);
            return sum;
        }
   }

}
