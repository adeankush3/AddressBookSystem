using AddressBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Program
    {
        static Dictionary<int, string> ContactsList = new Dictionary<int, string>();
        public static void GetContactList() {
            if (ContactsList.Count > 0)
            {
                foreach (var contact in ContactsList)
                    Console.WriteLine("\n Name: " + contact.Value + " Number: " + contact.Key + " \n ");
            }
            else
            {
                Console.WriteLine("\n No contacts found in the ContactList. Add a new contact to proceed further: \n");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book Program");
            
            AddressBookMenu addressBookMenu = new AddressBookMenu();
            
            Console.WriteLine("Select option: \n 1. Add Contact\n 2.Edit Contact\n 3.Delete Contact\n 4.Exit");
            
            int num1 = int.Parse(Console.ReadLine());

            switch (num1)
            {
               
                case 1:
                    addressBookMenu.AddContact();
                    break;

                case 2:
                    Console.WriteLine("Enter Name for perform Edit Operation:\n");
                    string edit = Console.ReadLine();
                    addressBookMenu.EditContact(edit);
                    addressBookMenu.Display();
                    break;
                
                case 3:
                    Console.WriteLine("Enter Name for perform Delete Operation:\n");
                    string delete = Console.ReadLine();
                    addressBookMenu.DeleteContact(delete);
                    addressBookMenu.Display();
                    break;

                default:
                    Console.WriteLine("invalid input");
                    break;
            }
            addressBookMenu.Display();
        }
    }
}
