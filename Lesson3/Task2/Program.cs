//2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечетных положительных чисел.Сами числа и сумму вывести на экран, используя tryParse;
//б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.При возникновении ошибки вывести сообщение.Напишите соответствующую функцию;
//Студент: Камышанов Дмитрий
using System;
using Routinely;

namespace Tasks
{
    class Tasks
    {
        static void Main()
        {
            int sum = 0;
            int i;
            string s;
            bool flag;
            string msg = "Вводите числа, а не буквы";
            Ez.Print("Вводите числа");
            do
            {

                do
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    s = Console.ReadLine();
                    flag = int.TryParse(s, out i);
                    if (flag == false)
                    {
                        Console.Beep();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Ez.Print(msg);
                    }
                }
                while (!flag);
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
            Ez.Print($"{sum}");
            Ez.Pause();
        }
    }

}
