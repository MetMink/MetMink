//* Задача ЕГЭ.
// На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней
//школы.В первой строке сообщается количество учеников N, которое не меньше 10, но не
//превосходит 100, каждая из следующих N строк имеет следующий формат:
//<Фамилия> <Имя> <оценки>,
//где<Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не
//более чем из 15 символов, <оценки> — через пробел три целых числа, соответствующие оценкам по
//пятибалльной системе. <Фамилия> и<Имя>, а также<Имя> и<оценки> разделены одним пробелом.
//Пример входной строки:
//Иванов Петр 4 5 3
//Требуется написать как можно более эффективную программу, которая будет выводить на экран
//фамилии и имена трёх худших по среднему баллу учеников. Если среди остальных есть ученики,
//набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.
//Сделайте меню с выбором демонстрации решения. Добавьте обработку исключений в меню, так
//чтобы если вдруг в каком-то решении,, что-то пошло не так можно было вернуться в меню и
//продолжить выбор задач.



using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int u = 0;
            int i = 0;
            StreamReader fileIn = new StreamReader(@"C:\\Users\\user\\Desktop\\ЕГЭ.txt", Encoding.GetEncoding(1251));
            StreamWriter fileOut = new StreamWriter(@"C:\\Users\\user\\Desktop\\numbers.txt");
            string text = fileIn.ReadToEnd();
            Regex r = new Regex(@"[-+]?[2-5]");
            Regex name = new Regex(@"[А - Я][^а-я]\D\S");
            Match match = name.Match(text);
            while (match.Success)
            {
                u++;
                match = match.NextMatch();
            }
            Console.WriteLine($"Количество учеников - {u / 2}\n");

            for (int j = 0; j < text.Length; j++)
            {
                Console.Write(text[j]);
            }
            Match integer = r.Match(text);
            while (integer.Success)
            {
                fileOut.WriteLine(integer);
                i++;
                integer = integer.NextMatch();
            }
            Console.WriteLine();
            fileIn.Close();
            fileOut.Close();
            StreamReader numbers = new StreamReader(@"C:\\Users\\user\\Desktop\\numbers.txt");
            StreamWriter nums = new StreamWriter(@"C:\\Users\\user\\Desktop\\nums.txt");
            string text1 = numbers.ReadToEnd();
            string [] text2 = numbers.ReadLine().Split(' ', '\n');
            int[] massive = new int[text1.Length];
            for (int j = 0; j < text1.Length; j++)
            {
                massive[j] = Convert.ToInt32((Char.GetNumericValue(text1[j])));
                Console.WriteLine(massive[j]);


            }
            //for (int j = 0; i < ; j++)
            //{

            //}
            nums.Close();
            Console.ReadKey();
        }
        
        }

}
