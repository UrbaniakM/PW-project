using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// dlls
using Urbaniak.PW_project.INTERFACES;
using Urbaniak.PW_project.CORE;

namespace Urbaniak.PW_project.BL
{
    internal abstract class ObjectBL<T> : IObjectBL<T>
    {
        private readonly IDAOObject<T> _dao;

        internal ObjectBL(IDAOObject<T> dao)
        {
            _dao = dao;
        }

        public bool Add(T obj) => _dao.Add(obj);

        public List<T> GetAll() => _dao.GetAll();

        public T GetById(uint id) => _dao.GetById(id);

        public List<T> GetByName(string name) => _dao.GetByName(name);

        public bool Remove(uint id) => _dao.Remove(id);

        public bool Update(T obj) => _dao.Update(obj);
    }
}
