

//Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause)
using System;


namespace Kamyshanov
{
    class Kamyshanov
    {
        static void Print(string msg)
        {
            Console.WriteLine(msg);             //Ввод текста
        }


        static void Pause()
        {
            Console.ReadKey();                  //Пауза
        }

        static void CentOFScreen(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);    //Центр экрана и вывод сообщения
            Print(msg);
        }


        static double EnterDouble()
        {
            return Convert.ToDouble(Console.ReadLine());      //Ввод десятичного числа  
        }

        static double CordDist(double x1, double y1, double x2, double y2)
        {
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));      //Вычисление расстояния между точками
            return r;
        }
    }
}
