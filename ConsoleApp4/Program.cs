using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x1");
            double x1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y1");
            double y1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x2");
            double x2=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y2");
            double y2=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите a");
            double a=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b");
            double b=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c");
            double c=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"d={f(x1, y1, x2, y2)}");
            Console.WriteLine($"p={d(a,b,c)}");
            Console.ReadKey();
        }

        static double f(double x1, double y1, double x2, double y2)
        {
            return (double)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static double d(double a, double b, double c)
        {
            return a + b + c;
        }
            
    }
}
