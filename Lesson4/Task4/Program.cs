//*Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
//Создайте структуру Account, содержащую Login и Password.Использовать StreamReader.
//Студент: Камышанов Дмитрий
using System;
using System.IO;

namespace Task4
{
    struct Account
    {
        public string login;
        public string password;
    }
    class Program
    {
        static string[] Import(string [] login)
        {
            
            try
            {
                FileStream fileStream = new FileStream("C:\\Users\\user\\Desktop\\2.bin", FileMode.Open);    //адрес файла изменить при необходимости
                StreamReader sr = new StreamReader(fileStream);
                for (int i = 0; i < login.Length; i++)
                {
                    login[i] = sr.ReadLine();
                    Console.WriteLine(login[i]);
                }
                sr.Close();
            }
            catch (FileNotFoundException exc)
            {
                Console.WriteLine(exc.Message);
            }
            return login;
        }
        static void Main(string[] args)
        {
            
            string[] login = new string[2];
            Import(login);
            Account logPass;
            logPass.login = login[0];
            logPass.password = login[1];
            int attempts = 3;
            do
            {
                Console.WriteLine($"Проверка логина и пароля. Осталось попыток {attempts}");
                Console.WriteLine("login:");
                string log = Console.ReadLine();
                Console.WriteLine("password:");
                string pass = Console.ReadLine();
                if ((log != login[0] & pass != login[1]) | (log == login[0] & pass != login[1]) | (log != login[0] & pass == login[1]))
                {
                    attempts--;
                }
                else if (log == logPass.login & pass == logPass.password)
                {
                    Console.WriteLine("Добро пожаловать!");
                    break;
                }
            }
            while (attempts != 0);
            if (attempts == 0)
            {
                Console.WriteLine("Превышено число доступных попыток ввода логина и пароля. Доступ закрыт.");
            }
            Console.ReadKey();
        }
    }
}
