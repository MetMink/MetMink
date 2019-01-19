//Написать метод подсчета количества цифр числа. Студент: Камышанов Дмитрий

using System;
using Routinely;


namespace homework
{
   public partial class Tasks
    {
        public static int NumOfDigs ()
        {
            int nums = 0;
            double chislo = Ez.EnterDouble();
            do
            {
                chislo = chislo / 10;
                nums++;
            }
            while (chislo == 0);
            return nums;
        }
    }
}
