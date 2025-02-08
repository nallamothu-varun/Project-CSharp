using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadDocumentFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter file location:");
            string path = Console.ReadLine();

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists == true)
            {
                //using File object
                Console.WriteLine(File.ReadAllText(path));
                //Need array of strings to use ReadAllLines
                File.AppendAllText(path, "\nHello");    
                string[] docText = File.ReadAllLines(path);
                foreach (string line in docText)
                {
                    Console.WriteLine(line);
                }

            }
            else
            {
                Console.WriteLine("Please enter the correct file location");
            }

            Console.Read();
        }
    }
}
