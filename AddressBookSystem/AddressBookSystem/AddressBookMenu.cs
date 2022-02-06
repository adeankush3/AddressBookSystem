using AddressBookSystem;
using System;
using System.Collections.Generic;

namespace AddressBook
{
    public class AddressBookMenu
    {
        List<Contacts> addressBook = new List<Contacts>();
        public void AddContact()
        {

            Contacts contacts = new Contacts();

            System.Console.WriteLine("Enter Your First Name: ");
            contacts.FirstName = Console.ReadLine();

            System.Console.WriteLine("Enter Your Last Name: ");
            contacts.LastName = Console.ReadLine();

            System.Console.WriteLine("Enter Your Address: ");
            contacts.Address = Console.ReadLine();

            System.Console.WriteLine("Enter Your City: ");
            contacts.City = Console.ReadLine();

            System.Console.WriteLine("Enter Your State: ");
            contacts.State = Console.ReadLine();

            System.Console.WriteLine("Enter Your Zip Code: ");
            contacts.Zip = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Enter Your Phone Number: ");
            contacts.PhoneNumber = Console.ReadLine();

            System.Console.WriteLine("Enter Your Email-Id: ");
            contacts.Email = Console.ReadLine();

            addressBook.Add(contacts);
        }
    }
}