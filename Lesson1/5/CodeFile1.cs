using System;

class Program
{
    static void Main()
    {
        //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        Console.WriteLine("а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.Камышанов Дмитрий");
        string firstname, secondname, city;
        Console.WriteLine("Введите имя");
        firstname = Console.ReadLine();
        Console.WriteLine("Введите фамилию");
        secondname = Console.ReadLine();
        Console.WriteLine("Введите город проживания");
        city = Console.ReadLine();
        Console.WriteLine($"{firstname} {secondname}, город проживания: {city}");
        Console.ReadKey();
    }
}