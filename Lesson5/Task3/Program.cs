//Разработать статический класс Message, содержащий следующие статические методы для
//обработки текста:
//а) Вывести только те слова сообщения, которые содержат не более n букв.
//б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
//в) Найти самое длинное слово сообщения.
//г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
//д) *** Создать метод, который производит частотный анализ текста.В качестве параметра в
//него передается массив слов и текст, в качестве результата метод возвращает сколько раз
//каждое из слов массива входит в этот текст.Здесь требуется использовать класс Dictionary.
//е) * Использовать коллекции List<string>;




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3
{
    static class Message
    {
        static void Choice (int n)
        {



        }
        static void Main(string[] args)
        {
            FileStream fileStream = new FileStream("C:\\Users\\user\\Desktop\\hobbit.txt", FileMode.Open);
            StreamReader text = new StreamReader(fileStream);
            string text1 = text.ReadToEnd();
            for (int i = 0; i < text1.Length; i++)
            {
                Console.Write(text1[i]);
            }


            Console.ReadKey();
        }
    }
}
