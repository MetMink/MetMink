//* Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел.Предусмотреть методы сложения, вычитания, умножения и деления дробей.
//Написать программу, демонстрирующую все разработанные элементы класса.
//Студент: Камышанов Дмитрий
using System;
using Routinely;


namespace Fraction
{
    class Fraction
    {
        int numerator;
        int denominator;
        public Fraction ()
        {
            numerator = 0;
            denominator = 0;
        }
        public Fraction (int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        //public static int NOD(int a, int b)
        //{
        //    if (b < 0)
        //        b = -b;
        //    if (a < 0)
        //        a = -a;
        //    while (b > 0)
        //    {
        //        int temp = b;
        //        b = a % b;
        //        a = temp;
        //    }
        //    return a;
        //}
        //public static int Easy(int a, int b)
        //{
        //    a = a / NOD(a, b);

        //    return a;
        //}
        public Fraction Plus(Fraction d2)
        {
            Fraction d3 = new Fraction();

            int nok = 0;
            for (int i = 0; i < (d2.denominator * denominator + 1); i++)
            {
                if (i % denominator == 0 && i % d2.denominator == 0)
                {
                    nok = i;
                    if (i != 0)
                    {
                        break;
                    }
                }
            }
            int domn1 = nok / denominator;
            int domn2 = nok / d2.denominator;
            d3.numerator = (numerator * domn1) + (d2.numerator * domn2);
            d3.denominator = nok;
            return d3;


            }
        public Fraction Minus(Fraction d2)
        {
            Fraction d3 = new Fraction();
            int nok = 0;
            for (int i = 0; i < (d2.denominator * denominator + 1); i++)
            {
                if (i % denominator == 0 && i % d2.denominator == 0)
                {
                    nok = i;
                    if (i != 0)
                    {
                        break;
                    }
                }
            }
            int domn1 = nok / denominator;
            int domn2 = nok / d2.denominator;
            d3.numerator = (numerator * domn1) - (d2.numerator * domn2);
            d3.denominator = nok;
            return d3;
        }
        public Fraction Multi (Fraction d2)
        {
            Fraction d3 = new Fraction();
            d3.numerator = numerator * d2.numerator;
            d3.denominator = denominator * d2.denominator;
            return d3;
        }
        public Fraction Del (Fraction d2)
        {
            d2.numerator = d2.numerator + d2.denominator;
            d2.denominator = d2.numerator - d2.denominator;
            d2.numerator  = d2.numerator - d2.denominator;
            Fraction d3 = new Fraction();
            d3.numerator = numerator * d2.numerator;
            d3.denominator = denominator * d2.denominator;
            return d3;

        }
        public string toString ()
        {
            if (denominator == 1)
            {
                return numerator + " ";
            }
            else
            {
                return numerator + "/" + denominator;
            }
        }

        static void Main(string[] args)
        {
            int a, b, c, d;
            Ez.Print("Введите числитель 1");
            a = Ez.EnterInt();
            Ez.Print("Введите знаменатель 1");
            b = Ez.EnterInt();
            if (b == 0) throw new ArgumentOutOfRangeException("Знаменатель не может быть равен нулю");
            Ez.Print("Введите числитель 2");
            c = Ez.EnterInt();
            Ez.Print("Введите знаменатель 2");
            d = Ez.EnterInt();
            if (d == 0) throw new ArgumentOutOfRangeException("Знаменатель не может быть равен нулю");
            Fraction d1;
            d1 = new Fraction(a, b);
            Fraction d2 = new Fraction(c, d);
            Fraction result;
            Ez.Print("Выберите операцию:\n1 - Умножение;\n2 - Деление;\n3 - Сложение;\n4 - Вычитание.");
            string z = Console.ReadLine();
            if (z == "1")
            {
                result = d1.Multi(d2);
                Ez.Print(result.toString());
            }
            if (z == "2")
            {
                result = d1.Del(d2);
                Ez.Print(result.toString());
            }
            if (z == "3")
            {
                result = d1.Plus(d2);
                Ez.Print(result.toString());
            }
            if (z == "4")
            {
                result = d1.Minus(d2);
                Ez.Print(result.toString());
            }
            
            Ez.Pause();
        }
    }
}

