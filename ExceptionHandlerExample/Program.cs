using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlerExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Division of 2 numbers
                Console.WriteLine("Please enter the first number:");
                int firstNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the first number:");
                int secondNumber = Convert.ToInt32(Console.ReadLine());

                int result = firstNumber/secondNumber;

                Console.WriteLine("The result for the division is:" +result);
                Console.ReadLine();
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
