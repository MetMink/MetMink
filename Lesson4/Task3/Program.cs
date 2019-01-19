//а) Дописать класс для работы с одномерным массивом.Реализовать конструктор, создающий
//массив определенного размера и заполняющий массив числами от начального значения с
//заданным шагом.Создать перечисление FillType которое определяет, как заполнять массив:
//случайными числами или с заданным шагом.Создать свойство Sum, которое возвращает сумму
//элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у всех
//элементов массива (старый массив, остается без изменений), метод Multi, умножающий каждый
//элемент массива на определённое число, свойство MaxCount, возвращающее количество
//максимальных элементов.
//б)** Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу
//библиотеки
//Студент: Камышанов Дмитрий.

using System;
using System.Collections;
using CoolArrays;

namespace Homework
{
    class Program
    {
        static void Main(string [] args)
        {
            CoolArray.FillType fill = 0;
            CoolArray Arr;
                Console.WriteLine("Как будет заполняться массив: рандомом или с определенным шагом?");
                string ch = Console.ReadLine();
                if (ch == "1")
                {
                fill = CoolArray.FillType.Randoms;
                }
                else if (ch == "2")
                {
                fill = CoolArray.FillType.Step;
                }
            switch (fill)
            {
                case CoolArray.FillType.Randoms:
                    {
                        Console.WriteLine("Введите размер массива:");
                        int i = Convert.ToInt32(Console.ReadLine());
                        Arr = new CoolArray(i);
                        Arr.Print();
                        int[] mud = new int[i];
                        for (int b = 0; b < mud.Length; b++)        //не получилось реализовать инверсию через класс, создал массив, который копирует изачальный массив
                        {
                            mud[b] = Arr[b];
                        }
                        Console.WriteLine(" ");
                        Console.WriteLine("\nМаксимальное значение:  " + Arr.Max);
                        Console.WriteLine($"Сумма - {Arr.Sum}");
                        Console.WriteLine($"{Arr.Inverse(mud)}");
                        Console.WriteLine("\nНа сколько умножить");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Arr.Multi(n));
                        Console.WriteLine(Arr.MaxCount);
                        

                        break;
                    }
                case CoolArray.FillType.Step:
                    {
                        Console.WriteLine("Введите размер массива:");
                        int i = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите шаг, через который будет заполняться  массив:");
                        int j = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите начальное значение:");
                        int h = Convert.ToInt32(Console.ReadLine());
                        Arr = new CoolArray(i, j, h);
                        Arr.Print();
                        int[] mud = new int[i];
                        for (int b = 0; b < mud.Length; b++)        //не получилось реализовать инверсию через класс, создал массив, который копирует изачальный массив
                        {
                            mud[b] = Arr[b];
                        }
                        Console.WriteLine(" ");
                        Console.WriteLine("\nМаксимальное значение: " + Arr.Max);
                        Console.WriteLine($"Сумма - {Arr.Sum}");
                        Console.WriteLine($"{Arr.Inverse(mud)}");
                        Console.WriteLine("\nНа сколько умножить");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Arr.Multi(n));
                        Console.WriteLine(Arr.MaxCount);
                        break;
                    }
            }

            Console.ReadKey();
        }
    }
}
