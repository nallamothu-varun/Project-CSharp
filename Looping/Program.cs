using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping
{
    internal class Looping
    {
        public string whileloop(int number)
        {
            int i = 0;
            while(i <= number)
            {
                Console.WriteLine(i);
                i++;
            }

            return "While loop completed";
        }

        public string CheckEven(int number) {

            int i = 0;
            while (i <= number)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);

                i++;
            }
            return "Even Number check completed";
        }


        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter the number");
            int count = Convert.ToInt16(Console.ReadLine());

            Looping loop = new Looping();
            Console.WriteLine(loop.whileloop(count));
            Console.WriteLine(loop.CheckEven(count));

            Console.Read();
        }
    }
}
