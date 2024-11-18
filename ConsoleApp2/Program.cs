using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"b={Func(a)}");
            Console.ReadKey();
        }
        static double Func(double a)
        {
            return 12 * Math.Pow(a, 2) + 7 * a - 6;
        }
              
    }
}
