using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// dlls
using Urbaniak.PW_project.CORE;
using Urbaniak.PW_project.INTERFACES;

namespace Urbaniak.PW_project.DAO
{
    internal class ProducentsDAO : IProducentsDAO
    {
        private List<IProducent> list;

        internal ProducentsDAO()
        {
            list = new List<IProducent>();
            Producent producent1 = new Producent("Stock Polska Sp. z o.o.", "Spółdzielcza 6, 20-402 Lublin");
            Producent producent2 = new Producent("CEDC International sp. z o.o.", "Kowanowska 48, 64-600, Oborniki Wlkp.");
            Producent producent3 = new Producent("V&S VIN & SPRIT", "Årstaängsvägen 19a, 117 97,  Stockholm", Country.Sweden);
            list.Add(producent1);
            list.Add(producent2);
            list.Add(producent3);
        }

        public bool Add(IProducent obj)
        {
            GetAll().Add(obj);
            return true;
        }

        public List<IProducent> GetAll() => list;

        public IProducent GetById(uint id)
        {
            return GetAll().FirstOrDefault(obj => obj.Id == id);
        }

        public List<IProducent> GetByName(string name)
        {
            List<IProducent> returnList = new List<IProducent>();
            foreach(IProducent producent in list)
            {
                if(producent.Name.Equals(name))
                {
                    returnList.Add(producent);
                }
            }
            return returnList;
        }

        public IProducent CreateNewObj()
        {
            return new Producent();
        }

        public bool Remove(uint id)
        {
            return GetAll().RemoveAll(obj => obj.Id == id) > 0;
        }

        public IProducent Update(IProducent obj)
        {
            int index = GetAll().FindIndex(el => el.Id == obj.Id);
            if(index >= 0)
            {
                GetAll()[index] = obj;
            }
            return obj;
        }
    }
}
