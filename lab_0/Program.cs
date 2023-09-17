using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_0
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Реализовать функцию возведения в квадрат суммы двух вещественных чисел");

            Random random = new Random();


            double number1 = random.NextDouble() * (-100) + 20;
            double number2 = random.NextDouble() * (-80) + 50;

            Console.WriteLine($"(({number1}) + ({number2})^2) = {Math.Pow(number1 + number2,2)}");
        }

       

    }
}
