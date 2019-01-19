//а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
//Студент: Камышанов Дмитрий



using System;
using Routinely;

struct Complex
{
    public double im;
    public double re;
    public Complex Plus(Complex x)
    {
        Complex y;
        y.im = im + x.im;
        y.re = re + x.re;
        return y;
    }
    public Complex Multi(Complex x)
    {
        Complex y;
        y.im = re * x.im + im * x.re;
        y.re = re * x.re - im * x.im;
        return y;
    }
   public Complex Minus(Complex x)
    {
        Complex y;
    y.im = im - x.im;
        y.re = re - x.re;
        return y;
    }
public string ToString()
    {
        return re + "+" + im + "i";
    }
}
class Program
{
    static void Main(string[] args)
    {
        Complex result;
        Complex complex1;
        Ez.Print("Введите вещественную часть комплексного числа 1");
        complex1.re = Ez.EnterDouble();
        Ez.Print("Введите мнимую часть комплексного числа 1");
        complex1.im = Ez.EnterDouble();

        Complex complex2;
        Ez.Print("Введите вещественную часть комплексного числа 2");
        complex2.re = Ez.EnterDouble();
        Ez.Print("Введите мнимую часть комплексного числа 2");
        complex2.im = Ez.EnterDouble();

        Ez.Print("Выберите операцию с комплексными числами:\n1 - сложение;\n2 - вычитание;\n3 - умножение");
        string key = Console.ReadLine();
        if (key == "1")
        {
            result = complex1.Plus(complex2);
            Console.WriteLine(result.ToString());
        }
        else if (key == "2")
        {
            result = complex1.Minus(complex2);
            Console.WriteLine(result.ToString());
        }
        else if (key == "3")
        {
            result = complex1.Multi(complex2);
            Console.WriteLine(result.ToString());
        }
        Ez.Pause();
    }
}
