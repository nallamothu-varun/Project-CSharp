using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the string to reverse:");
            string value = Console.ReadLine();
            int stringSize = value.Length;
            string reverseString = "";
            for (int i = stringSize; i >= 1; i--)
            {
                reverseString += value[i - 1].ToString();
                
            }
            Console.WriteLine("String reversal output:" +reverseString);
            Console.Read();
        }
    }
}
