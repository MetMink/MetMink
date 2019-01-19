using System;

class Program
{
    static void Print(string msg)
    {
        Console.WriteLine(msg);
    }
    static void Pause()
    {
        Console.ReadKey();
    }
    static void CentOFScreen(string msg, int x, int y)
    {
        Console.SetCursorPosition(x , y);
        Print(msg);
    }
    static void Main()
    {
        //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания. в) **Сделать задание б с использованием собственных методов
        Print("а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.\nв) **Сделать задание б с использованием собственных методов. Камышанов Дмитрий");
        string firstname, secondname, city;
        int x, y;
        Print("Введите имя");
        firstname = Console.ReadLine();
        Print("Введите фамилию");
        secondname = Console.ReadLine();
        Print("Введите город проживания");
        city = Console.ReadLine();
        x = Console.WindowWidth / 2;
        y = Console.WindowHeight / 2;
        CentOFScreen($"{firstname} {secondname}, город проживания: {city}", x, y);
        Pause();
    }
}