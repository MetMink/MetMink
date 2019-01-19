//создать программу, которая будет проверять корректность ввода логина.корректным
//логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита
//или цифры, при этом цифра не может быть первой:
//а) без использования регулярных выражений;
//б) ** с использованием регулярных выражений.


using System;
using System.Text.RegularExpressions;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            String login = string.Empty;
            Regex rg = new Regex(@"[A-Za-z]\d{0}");
            int j = 0;
            do
            {
                Console.WriteLine("Введите логин");
            login = Console.ReadLine();
            
            
                if (rg.IsMatch(login))
                {

                    if (login.Length <= 2)
                    {
                        Console.WriteLine("Логин слишком короткий");
                    }
                    else if (login.Length > 10)
                    {
                        Console.WriteLine("Логин слишком длинный");
                    }
                    else if (login[0] >= (char)(48) & login[0] <= (char)(57))
                    {
                        Console.WriteLine("Логин не может начинаться с цифры");
                    }
                    else
                    {
                        Console.WriteLine("Логин создан");
                        j = 1;
                    }

                }
                else {
                    Console.WriteLine("Используйте буквы латинского алфавита");
                }
            } while (j != 1);
            Console.ReadKey();
        }
    }
}
