using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Addition of two numbers

            Console.WriteLine("Please enter the first value");
            int firstNumber = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Please enter the second number");
            int secondNumber = Convert.ToInt16(Console.ReadLine());

            int sumResult = firstNumber + secondNumber;

            Console.WriteLine("Sum of two numbers:" + sumResult);

            Console.Read();
        }
    }
}
