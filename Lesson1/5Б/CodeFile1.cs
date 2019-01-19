using System;

class Program
{
    static void Main()
    {
        //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        Console.WriteLine("б) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания. \n*Сделать задание, только вывод организовать в центре экрана. Камышанов Дмитрий");
        string firstname, secondname, city;
        Console.WriteLine("Введите имя");
        firstname = Console.ReadLine();
        Console.WriteLine("Введите фамилию");
        secondname = Console.ReadLine();
        Console.WriteLine("Введите город проживания");
        city = Console.ReadLine();
        Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
        Console.WriteLine($"{firstname} {secondname}, город проживания: {city}");
        Console.ReadKey();
    }
}