using System;

namespace _5
{
    class calc
    {
        public double a;
        public double b;
        public double c;
        public static void kv(double a, double b, double c)
        {
            double D = Math.Sqrt(b * b - (4 * a * c));
            b *= -1;
            double x = (b + D) / (2 * a);
            if (D > 0) { double x2 = (b - D) / (2 * a); Console.WriteLine("\nОтвет: x1=" + x + " x2=" + x2); }
            else if (D == 0) { Console.WriteLine("\nОтвет: x=" + x); }
            else if (D < 0) { Console.WriteLine("\nРешения, т.е. корней нет."); }
        }
        public static void bikv(double a, double b, double c)
        {
            double D = Math.Sqrt(b * b - (4 * a * c));
            b *= -1;
            double x = (b + D) / (2 * a);
            double x2 = (b - D) / (2 * a);
            Console.WriteLine("\n\nt1 = " + x);
            Console.WriteLine("\nt2 = " + x2);
            if (D >= 0)
            {
                if (x < 0 && x2 < 0) { Console.WriteLine("\nРешения, т.е. корней нет."); }
                else if (x >= 0 && x2 >= 0)
                {
                    x = Math.Sqrt(x);
                    x2 = Math.Sqrt(x2);
                    Console.WriteLine("\nОтвет: x1=" + x + " x2=-" + x + " x3=" + x2 + " x4=-" + x2);
                }
                else
                {
                    if (x >= 0)
                    {
                        x = Math.Sqrt(x);
                        Console.WriteLine("\nОтвет: x1=-" + x + " x2=" + x);
                    }
                    else
                    {
                        x2 = Math.Sqrt(x2);
                        Console.WriteLine("\nОтвет: x1=-" + x2 + " x2=" + x2);
                    }
                }
            }
            else { Console.WriteLine("\nРешения, т.е. корней нет."); }
        }
    }
    class calc2 : calc { }
    class Program
    {
        static void Main(string[] args)
        {
            calc2.kv(2, 30, 5);
            calc2.bikv(1, 1, -3);
        }
    }

}
