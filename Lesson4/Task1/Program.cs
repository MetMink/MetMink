//Дан целочисленный  массив из 20 элементов.Элементы массива  могут принимать  целые значения  от –10 000 до 10 000 включительно.
//Заполнить случайными числами.Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. 
//В данной задаче под парой подразумевается два подряд идущих элемента массива.Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.
//Студент: Камышанов Дмитрий.


using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Lesson4
    {
        static void Main(string[] args)
        {
            int[] Arr = new int[20];
            int pares = 0;
            Random rnd = new Random();
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = rnd.Next(-10000, 10000);
                Console.WriteLine(Arr[i] );
                if (i >= 1)
                {
                    if ((Arr[i] % 3 == 0 & Arr[i - 1] % 3 != 0) | (Arr[i] % 3 != 0 & Arr[i - 1] % 3 == 0))
                pares++;
                }
            }
            
            Console.WriteLine($"Количество пар - {pares}");
            Console.ReadKey();
        }
    }
}
