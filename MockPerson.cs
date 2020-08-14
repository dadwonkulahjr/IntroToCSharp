using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntroToCSharp
{
    public class MockPerson : IComax
    {
        private List<Person> _listOfPersons;

        public MockPerson()
        {
            _listOfPersons = new List<Person>()
            {
                new Person(){Id=1, FirstName="Mark", LastName="Jabata"},
                new Person(){Id=2, FirstName="Mary", LastName="Andrew"},
                new Person(){Id=3, FirstName="Francis", LastName="Smith"}
            };
        }

        public int Count
        {
            get { return _listOfPersons.Count; }
        }

        public Person AddPerson(Person person)
        {
            person.Id = _listOfPersons.Max(x => x.Id) + 1;
            _listOfPersons.Add(person);
            return person;
        }

        public Person Delete(int id)
        {
            Person person = _listOfPersons.FirstOrDefault(x => x.Id == id);
            if(person != null)
            {
                _listOfPersons.Remove(person);
                return person;
            }
            else
            {
                throw new Exception($"Person with Id = #{id} cannot be found, neither deleted.");
            }
        }

        public IEnumerable<Person> GetListOfPerson()
        {
            return _listOfPersons;
        }

        public Person GetPerson(int id)
        {
            Person person = _listOfPersons.FirstOrDefault(x => x.Id == id);
            if (person != null)
            {

                return person;
            }
            else
            {
                throw new Exception($"Person with Id = #{id} cannot be found.");
            }
        }

        public Person Update(Person personChanges)
        {
            Person person = _listOfPersons.FirstOrDefault(x => x.Id == personChanges.Id);
            if (person != null)
            {
                person.FirstName = personChanges.FirstName;
                person.LastName = personChanges.LastName;
                return person;
            }
            else
            {
                throw new Exception($"Person with Id = #{personChanges.Id} cannot be found, neither updated.");
            }
        }
    }
}
