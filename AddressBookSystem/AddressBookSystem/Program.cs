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
            Console.WriteLine("Welcome To Address Book Program");
            
            AddressBookMenu addressBookMenu = new AddressBookMenu();
            
            System.Console.WriteLine("Select option: \n 1. Add Contact\n 2.Edit Contact\n 3.Exit");
            
            int num1 = int.Parse(Console.ReadLine());

            switch (num1)
            {
                case 1:
                    addressBookMenu.AddContact();
                    break;
                case 2:
                    addressBookMenu.EditContact("Ankush");
                    break;
                case 3:
                    break;
                default:
                    System.Console.WriteLine("invalid input");
                    break;
            }
        }
    }
}
