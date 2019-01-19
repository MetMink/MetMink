//2.	Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
//а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.
//    Использовать массив(или список) делегатов, в котором хранятся различные функции.
//б) * Переделать функцию Load, чтобы она возвращала массив считанных значений.Пусть она возвращает минимум через параметр(с использованием модификатора out). 
//Студент: Камышанов Дмитрий



using System;
using System.IO;
namespace DoubleBinary
{
    class Program
    {
        public delegate double Min (double a);
        public delegate double MinPar(double a, double b);
        public static double F(double x)
        {
            return x * x - 50 * x + 10;
        }
        public static double F2(double a, double x)
        {
            return a * (x * x);
        }
        public static void SaveFunc(Min J, string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(J(x));

                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public static void SaveFunc1(MinPar J, string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            Console.WriteLine("Введите а");
            double r = Convert.ToDouble(Console.ReadLine());
            double x = a;
            while (x <= b)
            {
                bw.Write(J(x,r));

                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public static double [] Load(string fileName, out double min)
        {
            
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            double [] func = new double[fs.Length / sizeof(double)];
            for (int i = 0; i < func.Length; i++)
            {
                // Считываем значение и переходим к следующему
                double a = bw.ReadDouble();
                func[i] = a;
                //Console.WriteLine(func[i]);
                if (func [i] < min) min = func[i];
            }
            bw.Close();
            fs.Close();
            return func;
        }
        static void Main(string[] args)
        {
            double a, b, c, min;
            Console.WriteLine("Введите нижнюю границу промежутка");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите верхнюю границу промежутка");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите шаг");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ВЫберите функцию: 1,2");
            string choice = Console.ReadLine();
            switch(choice)
            {
                case "1":
                    {
                        
                        SaveFunc(new Min(F), "C:\\Users\\User\\Desktop\\data1.bin", a, b, c);
                        double[] array = Load("C:\\Users\\User\\Desktop\\data1.bin", out min);
                        for (int i = 0; i < array.Length; i++)
                        {
                            Console.WriteLine(array[i]);
                        }
                        Console.WriteLine($"Минимальное значение - {min}");
                        break;
                    }
                case "2":
                    {
                        SaveFunc1(new MinPar(F2), "data1.bin", a, b, c);
                        double [] array = Load("data1.bin", out min);
                        for (int i = 0; i < array.Length; i++)
                        {
                            Console.WriteLine(array[i]);
                        }
                        Console.WriteLine($"Минимальное значение - {min}");
                        break;
                    }
            }

            Console.ReadKey();
        }
    }
}

