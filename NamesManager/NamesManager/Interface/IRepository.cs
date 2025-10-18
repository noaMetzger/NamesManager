using NamesManager.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesManager.Interface
{
    public interface IRepository <T>
    {
        List<T> GetAll();
        void Add(T obj);
        void Set(List<T> obj);

    }
}
