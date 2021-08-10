using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// repository is there for simple storage of data
namespace RepositoryExample
{
    class PeopleRepository
    {
        // we're using a static list here instead of a proper database
        // but the general idea still holds up once we cover databases
        // it's just another piece of code to replace and refactor nbd
        static List<Person> _people = new List<Person>
        {
            new Person{Name="Bob"},
            new Person{Name="Steve"}, // initializing with some people
        }; 
        // field (fields are just for the class inside)
        // "static" this field works differently than a normal field
        // you get one of these for all of the instances


        public List<Person> GetAll()
        {
            return _people;
        }

        public void Delete(string name)
        {
            var personToRemove = _people.First(person => person.Name == name);
            _people.Remove(personToRemove);
        }

        internal void Add(Person person)
        {
            _people.Add(person);
        }
    }
    class Person
    {
        public string Name { get; set; }
    }
}
