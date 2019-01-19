//б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;
//Студент: Камышанов Дмитрий
using System;
using Routinely;
class ComplexClass
{
    double im;
    double re;
    public ComplexClass()
    {
        re = 0;
        im = 0;
    }
    public ComplexClass(double re, double im)
    {
        this.im = im;
        this.re = re;
    }
    public ComplexClass Plus(ComplexClass x2)
    {
        ComplexClass x3 = new ComplexClass();
        x3.re = x2.re + re;
        x3.im = x2.im + im;
        return x3;
    }
    public ComplexClass Minus(ComplexClass x2)
    {
        ComplexClass x3 = new ComplexClass();
        x3.im = im - x2.im;
        x3.re = re - x2.re;
        return x3;
    }
    public ComplexClass Multi (ComplexClass x2)
        {
        ComplexClass x3 = new ComplexClass();
        x3.im = re* x2.im + im* x2.re;
        x3.re = re* x2.re - im* x2.im;
        return x3;
    }
public double Im
    {
        get { return im; }
        set
        {
            if (value >= 0) im = value;             //Замена мнимого числа, не использовал в своей работе
        }
    }
    public string ToString()
    {
        return re + "+" + im + "i";
    }
}
class ProgramClass
{
    static void Main(string[] args)
    {
        double a, b, c, d;
        Ez.Print("Введите вещественную часть комплексного числа 1");
        a = Ez.EnterDouble();
        Ez.Print("Введите мнимую часть комплексного числа 1");
        b = Ez.EnterDouble();
        Ez.Print("Введите вещественную часть комплексного числа 1");
        c = Ez.EnterDouble();
        Ez.Print("Введите мнимую часть комплексного числа 2");
        d = Ez.EnterDouble();
        ComplexClass complex1;
        complex1 = new ComplexClass(a, b);
        ComplexClass complex2 = new ComplexClass(c, d);
        ComplexClass result;

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
        Console.ReadKey();
    }
}
