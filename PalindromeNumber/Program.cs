using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number");
            string number = Console.ReadLine();
            string reverseNumber = "";
            for (int i = number.Length-1; i >= 0; i--)
            {
                string digit = number[i].ToString();
                reverseNumber += digit;
            }

            if (Convert.ToInt32(reverseNumber) == Convert.ToInt32(number))
            {
                Console.WriteLine("Given number is a Palindrome: " + number);
            }
            else
            {
                Console.WriteLine("Given number is not a Palindrome:" + number);
            }

            Console.Read();
        }
    }
}
