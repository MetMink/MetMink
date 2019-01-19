//Написать метод подсчета количества цифр числа. Студент: Камышанов Дмитрий

using System;
using Routinely;


namespace homework
{
   public partial class Tasks
    {
        public static int NumOfDigs ()
        {
            Ez.Print("Введите число:");
            int nums = 0;
            double chislo = Ez.EnterDouble();
            do
            {
                nums++;
                chislo = (int) chislo / 10;
            }
            while (chislo != 0);
            return nums;
        }
    }
}
