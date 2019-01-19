//а) Дописать класс для работы с одномерным массивом.Реализовать конструктор, создающий
//массив определенного размера и заполняющий массив числами от начального значения с
//заданным шагом.Создать перечисление FillType которое определяет, как заполнять массив:
//случайными числами или с заданным шагом.Создать свойство Sum, которое возвращает сумму
//элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у всех
//элементов массива (старый массив, остается без изменений), метод Multi, умножающий каждый
//элемент массива на определённое число, свойство MaxCount, возвращающее количество
//максимальных элементов.
//б)** Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу
//библиотеки//Студент: Камышанов Дмитрий.


using System;
using System.Linq;
using System.IO;
namespace CoolArrays
{
    class CoolArray
    {
        int[] a;
        Random rnd = new Random();
        public enum FillType
        {
            Randoms, Step
        };
        public CoolArray(int size, int step, int start)    //i - размер n - шаг 
        {
            a = new int[size];
            a[0] = start;
            for (int i = 1; i < a.Length; i++)
                a[i] = a[i - 1] + step;
        }
        public CoolArray(int n)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(1, 101);
        }
        public CoolArray(string filename)
        {
            //Если файл существует
            if (File.Exists(filename))
            {
                //Считываем все строки в файл
                string[] ss = File.ReadAllLines(filename);
                a = new int[ss.Length];
                //Переводим данные из строкового формата в числовой
                for (int i = 0; i < ss.Length; i++)
                    a[i] = int.Parse(ss[i]);
            }
            else Console.WriteLine("Error load file");
        }
        public int Max
        {
            get
            {
                return a.Max();
            }
        }
        public int Sum
        {
            get
            {
                int sum = 0;
                foreach (int el in a)
                {
                    sum += el;
                }
                return sum;
            }
        } //проверить позже
        public int this[int i]
        {
            get { return a[i]; }
            set { a[i] = value; }
        }
        public int[] Inverse(int[] b) //проверить позже
        {
            a = new int[b.Length];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = -b[i];
                Console.Write(a[i]+" ");
            }
            return a;
        }
        public int[] Multi(int b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] *= b;
                Console.Write(a[i]+" ");
            }
            return a;
        }
        public int MaxCount
        {
            get
            {
                int count = 0;
                a.Max();
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == a.Max())
                    {
                        count++;
                    }
                }
                return count;
            }
        }       //check
        public void Print()
        {
            foreach (int el in a)
                Console.Write("{0,4}", el);
        }

    }
}
