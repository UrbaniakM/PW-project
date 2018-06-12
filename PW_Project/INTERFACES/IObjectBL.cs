using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urbaniak.PW_project.INTERFACES
{
    public interface IObjectBL<T>
    {
        List<T> GetAll();
        List<T> GetByName(string name);
        T GetById(uint id);
        bool Add(T obj);
        T Update(T obj);
        bool Remove(uint id);
    }
}
