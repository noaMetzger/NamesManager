using NamesManager.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesManager.Class
{
    public class PeopleRepository:IPeopleRepository
    {
        private List<Person> _people;
        public PeopleRepository()
        {
            _people = new List<Person>();
        }
        public List<Person> GetAllPeople()
        {
            return _people;
        }
        public void AddPerson(Person person)
        {
            _people.Add(person);
        }
        public void SetPeople(List<Person> people)
        {
            _people = people;

        }
    }
}
