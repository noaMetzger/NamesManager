using NamesManager.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesManager.Class
{
    public class Repository <T>:IRepository<T>
    {
        private List<T> _people;
        public Repository()
        {
            _people = new List<T>();
        }
        public List<T> GetAll()
        {
            return _people;
        }
        public void Add(T obj)
        {
            _people.Add(obj);
        }
        public void Set(List<T> obj)
        {
            _people = obj;

        }
    }
}
