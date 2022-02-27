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
        
        static void Main(string[] args)
        {
            Dictionary<string, Contacts> Adressbooks = new Dictionary<string, Contacts>();
            Console.WriteLine("Welcome To Address Book Program");
            
            AddressBookMenu addressBookMenu = new AddressBookMenu();
            
            Console.WriteLine("Select option: \n 1. Add Contact\n 2.Edit Contact\n 3.Delete Contact\n 4.Serch City Or State 5.Exit");
            
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
               
                case 4:
                    Console.WriteLine("Serch City or State\n");
                    addressBookMenu.SearchCityOrState();
                    break;

                default:
                    Console.WriteLine("invalid input");
                    break;
            }
            addressBookMenu.Display();
        }
    }
}
