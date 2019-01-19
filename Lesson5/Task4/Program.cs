//* Для двух строк написать метод, определяющий, является ли одна строка перестановкой
//другой.
//Например:
//badc являются перестановкой abcd.



using System;

namespace Task4
{
    class Program
    {
        static void Reverse(string uno, string duo)
        {
            if (uno == duo)
            {
                Console.WriteLine("Вы ввели одинаковые строки");
            }
            else
            {
                if (uno.Length == duo.Length)
                {
                    int sum = 0;
                    for (int i = 0; i < uno.Length; i++)
                    {
                        for (int j = 0; j < duo.Length; j++)
                        {
                            if (uno[i] == duo[j])
                            {
                                sum++;
                            }
                        }
                    }
                    if (sum == uno.Length)
                    {
                        Console.WriteLine("2 строка является перестановкой 1-ой");
                    }
                    else if (sum != uno.Length)
                    {
                        Console.WriteLine("2 строка не является перестановкой 1-ой");
                    }
                }
                else
                {
                    Console.WriteLine("Длины строк не совпадают");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую строку");
            string uno = Console.ReadLine();
            Console.WriteLine("Введите вторую строку");
            string duo = Console.ReadLine();
            Reverse(uno, duo);
            Console.ReadKey();
        }
    }
}
