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
            addressBookMenu.AddContact();
        }
    }
}
