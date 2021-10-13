using System;
using System.Collections.Generic;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book!");
            ReadInput.PersonalDetails();
        }
    }
    class ReadInput
    {
        public static void PersonalDetails()
        {
            Console.Write("Enter your first name: ");
            string firstname = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter Address : ");
            var Addresses = Console.ReadLine();

            Console.Write("Enter City : ");
            string city = Console.ReadLine();

            Console.Write("Enter State : ");
            string state = Console.ReadLine();

            Console.Write("Enter ZipCode: ");
            string zipCode = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Enter EmailId: ");
            string Email = Console.ReadLine();
            // adding personal details  in the list
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            List<string> PersonList = new List<string>();

            PersonList.Add(firstname);
            PersonList.Add(lastName);
            PersonList.Add(city);
            PersonList.Add(state);
            PersonList.Add(zipCode);
            PersonList.Add(Email);

            foreach(string a in PersonList)
            {
                Console.WriteLine(a);
            }


        }
    }
}
