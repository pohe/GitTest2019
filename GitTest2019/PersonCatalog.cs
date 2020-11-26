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
            persons = new List<Person>();
        }

        public void AddPerson(Person p)
        {
            persons.Add(p);
        }
    }
}
