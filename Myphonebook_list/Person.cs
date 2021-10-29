using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myphonebook_list
{
    class Person
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public Person(string number, string name)
        {
            Name = name;
            Number = number;
        }
    }
}
