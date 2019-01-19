using System;

class Program
{
    static void Main()
    {
        //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле
        //r =Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой) Камышанов Дмитрий;
        Console.WriteLine("а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле" 
            + "\nr = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).\nВывести результат, используя спецификатор формата .2f (с двумя знаками после запятой); Камышанов Дмитрий");
        double x1, x2, y1, y2, r;
        Console.SetCursorPosition(0, 4);
        Console.WriteLine("Введите координату х1");
        x1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите координату y1");
        y1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите координату х2");
        x2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите координату y2");
        y2 = Convert.ToDouble(Console.ReadLine());
        r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        Console.WriteLine($"Расстояние между координатами r = {r:F}");
        Console.ReadKey();
    }
}