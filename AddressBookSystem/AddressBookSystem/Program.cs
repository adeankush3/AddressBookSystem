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
            
            Console.WriteLine("Select option: " +
                "\n 1.Add Contact " +
                "\n 2.Edit Contact" +
                "\n 3.Delete Contact "+
                "\n 4.Serch City Or State " +
                "\n 5.View Person In The City Or State" +
                "\n 6.Count Of Contact Persons " +
                "\n 7.Sort Contact By Alphabetical"+
                "\n 8.Sort Contact By City State Or Zip"+
                "\n 9.Read Write Contact Into Text File"+
                "\n 10.Read write Contact Into CSV File"+
                "\n 11.Invalid Input");
            
            int count = 0;
            int num1 = Convert.ToInt32(Console.ReadLine());

            switch (num1)
            {
                case 1:
                    Console.WriteLine("Enter count for Address book:");
                    int addCount = Convert.ToInt32(Console.ReadLine());
                    
                    Dictionary<int, string> dictionary = new Dictionary<int, string>();
                    for (int i = 1; i <= addCount; i++)
                    {
                        count++;
                       
                        List<AddressBookMenu> newAdd = new List<AddressBookMenu>();
                        
                        dictionary.Add(i, "Added");
                    }
                    Console.WriteLine(count + " Address Book Created..");
                    
                    addressBookMenu.AddContact();
                    break;

                case 2:
                    Console.WriteLine("Enter Name for perform Edit Operation:\n");
                    string edit = Console.ReadLine();
                    addressBookMenu.EditContact(edit);
                   // addressBookMenu.Display();
                    break;
                
                case 3:
                    Console.WriteLine("Enter Name for perform Delete Operation:\n");
                    string delete = Console.ReadLine();
                    addressBookMenu.DeleteContact(delete);
                    //addressBookMenu.Display();
                    break;

                case 4:
                    Console.WriteLine("Serch City or State\n");
                    string firstName = Console.ReadLine();
                    addressBookMenu.SearchCityOrState(firstName);
                    break;

                case 5:
                    Console.WriteLine("View Person In The City Or State\n");
                    string firstName1 = Console.ReadLine();
                    addressBookMenu.ViewPersonInTheCityOrState(firstName1);
                    break;

                case 6:
                    Console.WriteLine("Count Of Contact Persons");
                    int total = Convert.ToInt32(Console.ReadLine());
                    addressBookMenu.CountOfContactPersons(total);
                    break;
                
                case 7:
                    Console.WriteLine("Sort Contact By Alphabetical");
                    addressBookMenu.SortContactByAlphabetical();
                    break;
               
                case 8:
                    Console.WriteLine("Enter City Or State Or zip to sort the contacts");
                    string getstring = Console.ReadLine();
                    addressBookMenu.SortContactByCityStateOrZip(getstring);
                    break;
                
                case 9:
                    Console.WriteLine("Read write Contact Into Text File");
                    addressBookMenu.ReadWriteContactIntoTextFile();
                    Console.ReadLine();
                    break;

                case 10:
                    Console.WriteLine("Read write Contact Into CSV File");
                    addressBookMenu.ReadWriteContactIntoCSVFile();
                    Console.ReadLine();
                    break;


                default:
                    Console.WriteLine("invalid input");
                    break;
            }
        }
    }
}
