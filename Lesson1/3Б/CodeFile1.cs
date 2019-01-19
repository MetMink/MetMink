using System;

class Program
{
    static double CordDist (double x1, double y1, double x2, double y2)
    {
        double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return r;
    }
    static double EnterDouble()
    {
        return Convert.ToDouble(Console.ReadLine());
    }
    static void Main()
    {
        //б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода. Камышанов Дмитрий;
        Console.WriteLine("б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.; Камышанов Дмитрий");
        double x1, x2, y1, y2, r;
        Console.SetCursorPosition(0, 2);
        Console.WriteLine("Введите координату х1");
        x1 = EnterDouble();
        Console.WriteLine("Введите координату y1");
        y1 = EnterDouble();
        Console.WriteLine("Введите координату х2");
        x2 = EnterDouble();
        Console.WriteLine("Введите координату y2");
        y2 = EnterDouble();
        CordDist(x1, y1, x2, y2);
        Console.WriteLine($"Расстояние между координатами r = {CordDist(x1, y1, x2, y2):F}");
        Console.ReadKey();
    }
}