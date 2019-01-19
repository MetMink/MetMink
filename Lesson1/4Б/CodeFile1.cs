using System;

class Program
{
    static void Print(string msg)
    {
        Console.WriteLine(msg);
    }
    static int EnterInt()
    {
        return Convert.ToInt32(Console.ReadLine());
    }
    static void Main()
    {
        //Написать программу обмена значениями двух переменных:
        //а) с использованием третьей переменной; Камышанов Дмитрий
        Print("Написать программу обмена значениями двух переменных:"
        + "\nа) с использованием третьей переменной; Камышанов Дмитрий");
        Print("Введите а");
        int a, b;
        a = EnterInt();
        Print("Введите b");
        b = EnterInt();
        Print($"До обмена значения двух переменных a = {a} , b = {b}");
        a = a + b;
        b = a - b;
        a = a - b;
        Print($"После обмена значения двух переменных a = {a} , b = {b}");
        Console.ReadKey();
    }
}