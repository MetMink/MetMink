using System;

class Program
{
    static void Main()
    {
        //Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах. Камышанов Дмитрий.
        Console.WriteLine("Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h);\nгде m — масса тела в килограммах, h — рост в метрах. Камышанов Дмитрий.");
        double m, h, I;
        Console.WriteLine("Введите вес:");
        m = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите рост:");
        h = Convert.ToDouble(Console.ReadLine());
        I = m / (h * h);
        Console.WriteLine($"ИМТ = {I:F}");
        Console.ReadKey();
    }
}