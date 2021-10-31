using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myphonebook_list
{
    class Getstart
    {
        Phonebook contacts = new Phonebook();
        public void Action()
        {
            bool play = true;
            while (play)
            {
                Console.Clear();
                Console.WriteLine("Select an action:");
                Console.WriteLine("1. Add contacts");
                Console.WriteLine("2. Remove Contacts");
                Console.WriteLine("3. Show the phonebook");
                Console.WriteLine("4.Quit");
                int choice = Tryparse();
                switch (choice)
                {
                    case 1:
                        contacts.AddContacts();
                        break;
                    case 2:
                        contacts.DeleteContacts();
                        break;
                    case 3:
                        contacts.ShowPhoneBook();
                        Console.ReadLine();
                        break;
                    case 4:
                        play = false;
                        break;
                    default:
                        Console.WriteLine("You need to choose from 1 to 4.");
                        break;
                }
            }
        }
        public int Tryparse()
        {
            int input;
            while (int.TryParse(Console.ReadLine(), out input) == false)
            {
                Console.WriteLine("you haven't entered a correct integer, try again");
            }
            return input;
        }











    }
}
