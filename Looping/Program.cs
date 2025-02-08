using System;
using System.Collections;
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
                //i++;
            }

            return "While loop completed";
        }

        public string EvenNumberCheck(int number) {

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
            string[] options = {"1.While Loop", "2.Even Number" };
            Console.WriteLine("Please enter a option(1/2):");
            foreach(string o  in options) Console.WriteLine(o);
            int option = Convert.ToInt16(Console.ReadLine());

            Looping loop = new Looping();

            Console.WriteLine("Please enter the number");
            int count = Convert.ToInt16(Console.ReadLine());

            switch (option)
            {
                
                case 1:
                    Console.WriteLine(loop.whileloop(count));
                    break;
                case 2:
                    Console.WriteLine(loop.EvenNumberCheck(count));
                    break;
                    
            }

            Console.Read();
        }
    }
}
