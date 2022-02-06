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
        public void EditContact(string FirstName)
        {
            Contacts edit = new Contacts();

            foreach (var data in addressBook)
            {
                if (data.FirstName == FirstName)
                {
                    edit = data;
                    return;
                }
            }
            System.Console.WriteLine("choose option:\n 1. Last Name\n 2. Address\n 3. City\n 4. State\n 5. Zip\n 6. Phone number\n 7. Email\n 8.Exit");
            bool flag = true;

            while (flag)
            {
                int num = int.Parse(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        edit.LastName = Console.ReadLine();
                        break;
                    
                    case 2:
                        edit.Address = Console.ReadLine();
                        break;
                   
                    case 3:
                        edit.City = Console.ReadLine();
                        break;
                   
                    case 4:
                        edit.State = Console.ReadLine();
                        break;
                   
                    case 5:
                        edit.Zip = Convert.ToInt32(Console.ReadLine());
                        break;
                    
                    case 6:
                        edit.PhoneNumber = Console.ReadLine();
                        break;
                   
                    case 7:
                        edit.Email = Console.ReadLine();
                        break;
                    
                    case 8:
                        flag = false;
                        break;
                   
                    default:
                        System.Console.WriteLine("Choose Your Correct option..");
                        break;
                }

            }

        }
    }
}