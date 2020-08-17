using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntroToCSharp
{
    //This class can
    //perform all the CRUD operations
    //Create, Retrieved, Update, and Delete a Person
    //Object In Memory...
    public class MockPerson : IComax
    {
        #region Fields
        private List<Person> _listOfPersons;
        #endregion

        #region Constructor
        public MockPerson()
        {
            _listOfPersons = new List<Person>()
            {
                new Person(){Id=1, FirstName="Mark", LastName="Jabata"},
                new Person(){Id=2, FirstName="Mary", LastName="Andrew"},
                new Person(){Id=3, FirstName="Francis", LastName="Smith"}
            };
        }
        #endregion

        #region Property
        //Get the total count of Persons
        //In memory using the List<Person> class...
        public int Count
        {
            get { return _listOfPersons.Count; }
        }
        #endregion

        #region Methods
        //Add a person to the List<Person> class
        //In memory

        public Person AddPerson(Person person)
        {
            person.Id = _listOfPersons.Max(x => x.Id) + 1;
            _listOfPersons.Add(person);
            return person;
        }
        //Delete a person from the List<Person> class
        public Person Delete(int id)
        {
            Person person = _listOfPersons.FirstOrDefault(x => x.Id == id);
            if (person != null)
            {
                _listOfPersons.Remove(person);
                return person;
            }
            else
            {
                throw new Exception($"Person with Id = #{id} cannot be found, neither deleted.");
            }
        }
        //Retrieved all the person objects in memory
        //inside the List<Person> class
        public IEnumerable<Person> GetListOfPerson()
        {
            return _listOfPersons;
        }
        //Retrieved a specific person from in memory
        //Using the List<Person> class
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
        //Update a person in the List<Person> object
        //in memory..
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
        #endregion
    }
}
