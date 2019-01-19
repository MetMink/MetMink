//Реализовать метод проверки логина и пароля.На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел 
//(Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
//С помощью цикла do while ограничить ввод пароля тремя попытками.

using System;
using Routinely;

namespace homework
{
    public partial class Tasks
    {
        public static void login()
        {
            string login = "root";
            string password = "GeekBrains";
            int attempts = 3;
            do
            {
                Ez.Print($"Проверка логина и пароля. Осталось попыток {attempts}");
                Ez.Print("login:");
                string log = Console.ReadLine();
                Ez.Print("password:");
                string pass = Console.ReadLine();
                if ((log != login & pass != password) | (log == login & pass != password) | (log != login & pass == password))
                {
                    attempts--;
                }
                else if (log == login & pass == password)
                {
                    Ez.Print("Добро пожаловать!");
                    break;
                }
            }
            while (attempts != 0);
            if (attempts == 0)
            {
                Ez.Print("Превышено число доступных попыток ввода логина и пароля. Доступ закрыт.");
            }
            Ez.Pause();

        
        }
    }
}
