using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int result = Value(number1, number2);

            Console.WriteLine($"Сумма чисел: {result}");
            Console.ReadKey();

        }
        static int Value(int a, int b)
        {
            return a + b;
        }
    }
}
