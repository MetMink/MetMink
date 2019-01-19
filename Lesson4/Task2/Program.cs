//Реализуйте задачу 1 в виде статического класса StaticClass;
//а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
//б) * Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
//в)** Добавьте обработку ситуации отсутствия файла на диске.
//Студент: Камышанов Дмитрий

using System;
using System.IO;


namespace ConsoleApp1
{
    class Program
    {

        static int [] Import()
        {
            int[] Arr = new int[20];
            try
            {
                FileStream fileStream = new FileStream("C:\\Users\\user\\Desktop\\3.bin", FileMode.Open);    //адрес файла изменить при необходимости
                BinaryReader br = new BinaryReader(fileStream);
                for (int i = 0; i < Arr.Length; i++)
                {
                    Arr[i] = br.ReadInt32();
                }
                br.Close();
            }
            catch (FileNotFoundException exc)
            {
                Console.WriteLine(exc.Message);
            }
            return Arr;
        }
        static void Save(int [] Arr)
        {
            FileStream fileStream = new FileStream("C:\\Users\\user\\Desktop\\2.bin", FileMode.Create);      //адрес файла изменить при необходимости
            BinaryWriter bw = new BinaryWriter(fileStream);
            for (int i = 0; i < Arr.Length; i++)
                bw.Write(Arr[i]);
            bw.Close();
            fileStream.Close();
            Console.WriteLine();
        }
        static int PairsRandom ()
        {
            int[] Arr = new int[20];
            int pairs = 0;
            Random rnd = new Random();
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = rnd.Next(-10000, 10000);
                Console.WriteLine(Arr[i]);
                if (i >= 1)
                {
                    if ((Arr[i] % 3 == 0 & Arr[i - 1] % 3 != 0) | (Arr[i] % 3 != 0 & Arr[i - 1] % 3 == 0))
                        pairs++;
                }
            }
            Console.WriteLine("Сохранить данные массива? \n1 - да ;\n2 - нет");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Save(Arr);
            }
                return pairs;
        }
        static int PairsImport (int [] Arr)
        {
            int pairs = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine(Arr[i]);
                if (i >= 1)
                {
                    if ((Arr[i] % 3 == 0 & Arr[i - 1] % 3 != 0) | (Arr[i] % 3 != 0 & Arr[i - 1] % 3 == 0))
                        pairs++;
                }
            }
            Console.WriteLine("Сохранить данные массива? \n1 - да\n2 - нет");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Save(Arr);
            }
            return pairs;
        }
        static int Sum (int [] Arr)
        {
            int sum = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                sum += Arr[i];
            }
            return sum;
        }
    static void Main(string[] args)
        {
            Console.WriteLine("1 - сгенерировать сейчас ;\n2 - импортировать массив из файла");
            string choice = Console.ReadLine();
            if(choice == "1")
            {
                Console.WriteLine($"Количество пар - {PairsRandom()}");
            }
            if(choice == "2")
            {
                int[] Arr = Import();
                if (Sum(Arr) != 0)
                Console.WriteLine($"Количество пар - {PairsImport(Arr)}");

            }
            Console.ReadKey();
        }
    }
}
