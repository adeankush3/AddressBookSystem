using AddressBookSystem;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AddressBook
{
    public class AddressBookMenu
    {
        public List<Contacts> contact = new List<Contacts>();
        public void AddContact()
        {

            Contacts contacts = new Contacts();
            Console.WriteLine("Add New Contact:");
            
            int Add = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= Add; i++)
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

                contact.Add(contacts);

                Console.WriteLine("Contact added Successfully....");
                var checkDuplicate = contact.GroupBy(x => x.FirstName, StringComparer.OrdinalIgnoreCase).Where(y => y.Count() > 1).Select(z => z.Key).ToList();
                if (checkDuplicate.Equals(contacts.FirstName))
                {
                    Console.WriteLine("Record is already present in the addrebook");

                }
                else
                {
                    contact.Add(contacts);
                }
            }
        }

        public void EditContact(string firstName)
        {
            Contacts edit = new Contacts();

            foreach (var data in contact)
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
                        Console.WriteLine("Choose Your Correct option..");
                        break;
                }

            }
        }
        public void DeleteContact(string firstName)
        {
            Contacts delete = new Contacts();

            foreach (var data in contact)
            {
                if (data.FirstName == firstName)
                {
                    delete = data;
                }
            }
            contact.Remove(delete);

        }
        public void Display()
        {

            foreach (var data in contact)
            {
                Console.WriteLine("Contact Data is: \n" + data.FirstName + "\n" + data.LastName + "\n" + data.Address + "\n" + data.City + "\n" + data.State + "\n" + data.Zip + "\n" + data.PhoneNumber + "\n" + data.Email);

            }
        }
        public void SearchCityOrState(string firstName)
        {
            foreach (Contacts item in contact)
            {
                if (contact.Any(x => x.FirstName == firstName))
                {
                    Console.WriteLine("Person Present");
                }
                else
                {
                    Console.WriteLine("Person Not Found");
                }
            }
        }
        public void ViewPersonInTheCityOrState(string firstName)
        {
            foreach (Contacts item in contact)
            {
                if (contact.Any(x => x.FirstName == firstName))
                {
                    Console.WriteLine("Person Present");
                }
                else
                {
                    Console.WriteLine("Person Not Found");
                }
            }
        }



    }
}