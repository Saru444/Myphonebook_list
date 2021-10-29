using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myphonebook_list
{
    class Phonebook
    {
        public static List<Person> myPhoneBook = new();

        public void AddContacts()
        {
            Console.WriteLine("Enter contacts name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the contacts number");
            string number = Console.ReadLine();
            if (name == "" || number == "")
            {
                Console.WriteLine("The content can not be blank.Try again!");
                Console.WriteLine("Enter contacts name");
                name = Console.ReadLine();
                Console.WriteLine("Enter the contacts number");
                number = Console.ReadLine();
                myPhoneBook.Add(new Person(number,name));
            }
            else
            {
                myPhoneBook.Add(new Person(number, name));
            }
        }
        public void ShowPhoneBook()
        {
            foreach (var person in myPhoneBook)
            {

                Console.WriteLine($"{person.Name}---{person.Number}");
            }

        }
        public void DeleteContacts()
        {
            Console.WriteLine("Which contact do you want to delete?");
            string answer = Console.ReadLine();
            myPhoneBook.Remove(myPhoneBook.Find(x => x.Name == answer));       
        }





    }
}
