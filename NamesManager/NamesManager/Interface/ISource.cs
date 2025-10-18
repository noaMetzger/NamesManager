using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NamesManager.Class;

namespace NamesManager.Interface
{
    public interface ISource
    {
         List<Person> Read();
         void Write(List<Object> objects);
    }
}
