// Alex Quinn
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3;
            num1 = 18;
            num2 = 482.2;
            num3 = 382.222;
            double result = Add(5, 17.5);
            Console.WriteLine($"5 + 17.5 = {result.ToString("N2")}");
            result = Add(num1, num2);
            Console.WriteLine($"{num1} + {num2} = {result}");

            double[] nums = { num1, num2, num3 };


            Console.ReadKey();

        }
        static double Add(double[] numToAdd)
        {
            double r = 0;

            foreach (var number in numToAdd)
            {
                r += number;
            }

            return r;
        }

        static double Add(double x, double y)
        {
            return x + y;
        }
    }
}
