//Написать статический метод void CreateCharsFile(string filename, int start, int finish), который
//создает файл содержащий символы из заданного диапазона(от start до finish). Обработать корректно
//исключения связанные с невозможностью создания файла.


using System;
using System.IO;

namespace Lesson5
{
    class Program
    {
        static void CreateCharsFile(string filename, int start, int finish)
        {
            try
            {
                FileStream fileStream = new FileStream($"C:\\Users\\user\\Desktop\\{filename}.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(fileStream);
                for (int i = start; i <= finish; i++)
                {
                    sw.WriteLine(i + " " + (char)i);
                    if (i % 80 == 0) sw.WriteLine();
                    
                }
                sw.Close();
        }
            catch(System.Text.EncoderFallbackException msg)
            {
                Console.WriteLine(msg);
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка связанная с невозможностью создания файла");
            }

}



        static void Main(string[] args)
        {
            Console.WriteLine("Введите название файла");
            string filename = Console.ReadLine();
            Console.WriteLine("Введите нечальную точку");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите конечную точку");
            int finish = Convert.ToInt32(Console.ReadLine());
            CreateCharsFile(filename, start, finish);
            Console.ReadKey();
        }
    }
}
