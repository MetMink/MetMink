using System;
using Routinely;

namespace homework
{
    public partial class Tasks
    {
        public static void IMT ()
        {
        double m, h, I;
        Ez.Print("Введите вес:");
        m = Ez.EnterDouble();
        Ez.Print("Введите рост:");
        h = Ez.EnterDouble();
        I = m / (h* h);
        Console.WriteLine($"ИМТ = {I:F}");
        Console.ReadKey();
        }
    }
}
