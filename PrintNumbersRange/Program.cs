using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumbersRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide starting range number:");
            int startValue = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please enter ending range number:");
            int endValue = Convert.ToInt16(Console.ReadLine());

            for (int i = startValue; i <= endValue; i++)
            {
                Console.WriteLine(+i);
            }
            Console.Read();
        }
    }
}
