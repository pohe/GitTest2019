using System;
using System.Collections.Generic;
using System.Text;

namespace GitTest2019
{
    public class PersonCatalog
    {
        private List<Person> persons;

        public PersonCatalog()
        {
            //Added PersonCatalog constructor på GitHub server
            persons = new List<Person>();
        }

        public void AddPerson(Person p)
        {
            persons.Add(p);
        }

        public void AddPerson(string name)
        {
            Person P = new Person(){Name = name; }
            persons.Add(p);
        }

    }
}
