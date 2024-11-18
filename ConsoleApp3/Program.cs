using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a =Convert.ToDouble(Console.ReadLine());
            Console.Write("b=");
            double b =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"a+b={Sum(a, b)}");
            Console.WriteLine($"a-b={Min(a, b)}");
            Console.WriteLine($"a*b={Pro(a, b)}");
            Console.WriteLine($"a/b={Deo(a, b)}");
            Console.ReadKey();
            
        }
        static double Sum(double a, double b)
        {
            return a + b;
        }
        static double Min(double a, double b)
        {
            return a - b;

        }
        static double Pro(double a, double b)
        {
            return a * b;
        }
        static double Deo(double a, double b)
        {
            {
                return (double)a /(double)b;
            }
        }

    }
}
