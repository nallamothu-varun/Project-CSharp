using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array Example
            string[] familyNames = { "Raju", "Bujji" };
            //familyNames[2] = "gaitry";

            foreach (string familyName in familyNames)
            {
                Console.WriteLine(familyName);
            }

            //List Example
            List<string> names = new List<string>() { "varun", "Raja"};
            names.Add("Vinay");
            names.Add("Anil");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //ArrayList Example
            ArrayList myDetails = new ArrayList() { "varun", "29",0.22};
            myDetails.Add(3435802503);
            foreach (var name in myDetails)
            {
                Console.WriteLine(name);
            }
            Console.Read();
        }
    }
}
