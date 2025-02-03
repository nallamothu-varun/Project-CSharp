using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Name");
            string name = Console.ReadLine();
            Char[] nameCheck = name.ToCharArray();
            Array.Reverse(nameCheck);        
            string revName = new string(nameCheck);
            if (name == revName) Console.WriteLine("Given Name is a Palindrome"); else Console.WriteLine("Given name is not a palindrome");
            Console.Read();
        }
    }
}
