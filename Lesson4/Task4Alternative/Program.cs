//*Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
//Создайте структуру Account, содержащую Login и Password.Использовать StreamReader.
//В отличие от предыдущего варианта, сюда я загружаю массив со строками и он, методом перебора, подбирает нужный логин и пароль
// Студент: Камышанов Дмитрий

using System;
using System.IO;


namespace Task4Alternative
{
    struct Account
    {
        public string login;
        public string password;
    }
    class Program
    {
    static string[] Import(string[] login)
    {

        try
        {
            FileStream fileStream = new FileStream("C:\\Users\\user\\Desktop\\4.txt", FileMode.Open);    //адрес файла изменить при необходимости
            StreamReader sr = new StreamReader(fileStream);
            for (int i = 0; i < login.Length; i++)
            {
                login[i] = sr.ReadLine();
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
            Account log = new Account();
            log.login = "root";
            log.password = "GeekBrains";
            string logtry = "";
            string passtry = "";
        string[] login = new string[10];
        Import(login);
            int attempts = 3;
            for (int i = 0; i < login.Length; i++)
            {
                Console.WriteLine(login[i]);
                if(login[i] == log.login)
                {
                    Console.WriteLine("Совпадение найдено в логине");
                    System.Threading.Thread.Sleep(1000);
                    logtry = login[i];
                }
                if (login[i] == log.password)
                {
                    Console.WriteLine("Совпадение найдено в пароле");
                    System.Threading.Thread.Sleep(1000);
                    passtry = login[i];
                }
                else if (logtry == log.login & passtry == log.password)
                {
                    break;
                }
                else if (login[i] != log.login | login[i] != log.password)
                {
                    Console.WriteLine("Совпадение не найдено");
                    System.Threading.Thread.Sleep(1000);
                }
                
            }
            Console.WriteLine("Добро пожаловать");
            Console.ReadKey();
        }
    }
}