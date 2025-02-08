using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OopsExample
{
    internal class PersonDetails
    {
        string firstName;
        string lastName;
        string fatherName;
        string motherName;
        string mobileNumber;
        int hostelFee;

        public string AddDetails()
        {
            return "success";
        }
        static void Main(string[] args)
        {

            PersonDetails guestDetails = new PersonDetails();

            Console.WriteLine("Please enter firstName");
            guestDetails.firstName = Console.ReadLine();
            Console.WriteLine("Please enter lastName");
            guestDetails.lastName = Console.ReadLine();
            Console.WriteLine("Please enter fatherName");
            guestDetails.fatherName = Console.ReadLine();
            Console.WriteLine("Please enter motherName");
            guestDetails.motherName = Console.ReadLine();
            Console.WriteLine("Please enter mobileNumber");
            guestDetails.mobileNumber = Console.ReadLine();

            Console.Read();
        }
    }
}
