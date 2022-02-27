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
            Console.WriteLine("Add New Contact:");
            int contactsCount = Convert.ToInt32(Console.ReadLine());
            try
            {
                Contacts contact = new Contacts();
                
                bool present = Validate(contact.FirstName, contact.LastName);
                if (present)
                {
                    Console.WriteLine("Already Present ");
                    return;
                }

                contact.Add(contact);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }

            for (int i = 1; i <= contactsCount; i++)
            {
                Console.WriteLine("Enter details for " + i + " Contact");
                
                Console.WriteLine("Enter Your First Name: ");
                contacts.FirstName = Console.ReadLine();

                Console.WriteLine("Enter Your Last Name: ");
                contacts.LastName = Console.ReadLine();

                Console.WriteLine("Enter Your Address: ");
                contacts.Address = Console.ReadLine();

                Console.WriteLine("Enter Your City: ");
                contacts.City = Console.ReadLine();

                Console.WriteLine("Enter Your State: ");
                contacts.State = Console.ReadLine();

                Console.WriteLine("Enter Your Zip Code: ");
                contacts.Zip = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Your Phone Number: ");
                contacts.PhoneNumber = Console.ReadLine();

                Console.WriteLine("Enter Your Email-Id: ");
                contacts.Email = Console.ReadLine();

                addressBook.Add(contacts);

                Console.WriteLine("Contact added Successfully....");
            }
        }

        private bool Validate(object firstName, object lastName)
        {
            throw new NotImplementedException();
        }

        public void EditContact(string firstName)
        {
            Contacts edit = new Contacts();

            foreach (var data in addressBook)
            {
                if (data.FirstName == firstName)
                {
                    edit = data;
                    return;
                }
            }
            Console.WriteLine("choose option:\n 1. Last Name\n 2. Address\n 3. City\n 4. State\n 5. Zip\n 6. Phone number\n 7. Email\n 8.Exit");
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
        public void DeleteContact(string firstName)
        {
            Contacts delete = new Contacts();

            foreach (var data in addressBook)
            {
                if (data.FirstName == firstName)
                {
                    delete = data;
                }
            }
            addressBook.Remove(delete);

        }
        public void Display()
        {

            foreach (var data in addressBook)
            {
                Console.WriteLine("Contact Data is: \n" + data.FirstName + "\n" + data.LastName + "\n" + data.Address + "\n" + data.City + "\n" + data.State + "\n" + data.Zip + "\n" + data.PhoneNumber + "\n" + data.Email);

            }
        }
        
    }
}