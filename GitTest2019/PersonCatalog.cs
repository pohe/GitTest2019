using System;
using System.Collections.Generic;
using System.Text;

namespace GitTest2019
{
    public class PersonCatalog
    {
        private List<Person> persons;

        public int Count
        {
            //har added comment to count
            // kjsf
            get { return persons.Count; }
        }

        public PersonCatalog()
        {
            //Vi arbejder på konstruktøren
            //Added PersonCatalog constructor på GitHub server
            persons = new List<Person>();
        }

        public void AddPerson(Person p)
        { //Added comment to AddPerson Luop local added hos pohe
            persons.Add(p);
        }

        public void RemovePerson(string name)
        {
            for(int i =0; i < persons.Count; i++)
            {

                if (persons[i].Name == name)
                {
                    persons.RemoveAt(i);

                }
            }
        }

        public void AddPerson(string name)
        {
            Person p = new Person() {Name = name};
            persons.Add(p);
        }

    }
}
