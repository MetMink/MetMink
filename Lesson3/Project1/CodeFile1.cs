using System;

namespace Routinely
{
    public class Ez
    {
        public static void Print(string msg)
        {
            Console.WriteLine(msg);
        }

        public static void Pause()
        {
            Console.ReadKey();
        }
        public static double EnterDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        public static int EnterInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}