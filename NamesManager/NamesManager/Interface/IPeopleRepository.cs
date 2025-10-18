using NamesManager.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesManager.Interface
{
    public interface IPeopleRepository
    {
        List<Person> GetAllPeople();
        void AddPerson(Person person);
        void SetPeople(List<Person> people);

    }
}
