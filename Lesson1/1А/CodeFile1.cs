using System;

class Program
{
    static void Main()
    {
        // Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
        // а) используя  склеивание; Камышанов Дмитрий
        Console.WriteLine("Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес)." 
            +"\n В результате вся информация выводится в одну строчку: \n"
            + " а) используя  склеивание; Камышанов Дмитрий");
        string firstname, secondname, age, height, weight;
        Console.WriteLine("Введите имя:");
        firstname = Console.ReadLine();
        Console.WriteLine("Введите фамилию:");
        secondname = Console.ReadLine();
        Console.WriteLine("Введите возраст:");
        age = Console.ReadLine();
        Console.WriteLine("Введите рост:");
        height = Console.ReadLine();
        Console.WriteLine("Введите вес:");
        weight = Console.ReadLine();
        Console.WriteLine(firstname + " " + secondname + "; " + "Возраст: " + age + "; " + "Рост: " + height + "; " + "Вес: " + weight + ".");
        Console.ReadKey();
    }
}
