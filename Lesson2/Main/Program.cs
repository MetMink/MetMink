//Домашнее задание №2. Студент: Камышанов Дмитрий

using System;
using homework;
using Routinely;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Ez.Print("Домашнее задание №2. Введите номер задания от 1 до 7");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Ez.Print("Написать метод, возвращающий минимальное из трёх чисел.");
                    Ez.Print($"Минимальное из трех чисел: {Tasks.min()}");
                    break;
                case "2":
                    Ez.Print("Написать метод подсчета количества цифр числа.");
                    Ez.Print($"Количество чисел в числе: {Tasks.NumOfDigs()}");
                    break;
                case "3":
                    Ez.Print("С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечётных положительных чисел.");
                    Ez.Print($"Сумма введенных нечетных положительных чисел: {Tasks.SumOfNums()}");
                    break;
                case "4":
                    Ez.Print("Реализовать метод проверки логина и пароля.");
                    Tasks.login();
                    break;
            }
            Ez.Pause();
        }
    }
}
