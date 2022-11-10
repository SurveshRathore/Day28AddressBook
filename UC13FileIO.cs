using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day27AddressBook
{
    internal class UC13FileIO
    {
        public void writeAddressBook()
        {
            string fileName = @"D:\dotnet\UC\Day27AddressBook\Day27AddressBook\AddressBook.txt";
            FileStream F;
            try
            {
                // Check if file already exists. If no, create file.     
                if (!File.Exists(fileName))
                {
                    //F = new FileStream(fileName, FileMode.Create);
                    Console.WriteLine("Creating file");
                    using (StreamWriter sw = File.AppendText(fileName))
                    {
                        sw.WriteLine("FirstName LastName Address City State Zip PhoneNumber Email");
                    }
                }
                else
                {
                    //append file
                }

                Console.Write("Enter the person First Name: ");
                String fName = Console.ReadLine();
                Console.Write("Enter the person last Name: ");
                String lName = Console.ReadLine();
                Console.Write("Enter the person address: ");
                String address = Console.ReadLine();
                Console.Write("Enter the person city: ");
                String city = Console.ReadLine();
                Console.Write("Enter the person state: ");
                String state = Console.ReadLine();
                Console.Write("Enter the person zip: ");
                int zip = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the person phone number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the person email: ");
                String email = Console.ReadLine();

                //UC2AddContact addContact = new(fName, lName, city, state, zip, number, email);
                //addContact.personDetails();
                UC1Contact contact = new(fName, lName, address, city, state, zip, number, email);

                using (StreamWriter sw = File.AppendText(fileName))
                {
                    sw.WriteLine(fName, lName, address, city, state, zip, number, email);
                    sw.Write("{0} {1} {2} {3} {4} {5} {6} {7}", fName, lName, address, city, state, zip, number, email);
                }
                //    // Create a new file     
                //    using (StreamWriter sw = File.CreateText(fileName))
                //{
                //    sw.WriteLine("FirstName LastName Address City State Zip PhoneNumber Email");

                //    sw.WriteLine("Author: Mahesh Chand");
                //    sw.WriteLine("Add one more line ");
                //    sw.WriteLine("Add one more line ");
                //    sw.WriteLine("Done! ");
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
