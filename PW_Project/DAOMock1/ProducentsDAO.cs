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
        private List<Producent> list;

        internal ProducentsDAO()
        {
            list = new List<Producent>();
            Producent producent1 = new Producent("Stock Polska Sp. z o.o.", "Spółdzielcza 6, 20-402 Lublin");
            Producent producent2 = new Producent("CEDC International sp. z o.o.", "Kowanowska 48, 64-600, Oborniki Wlkp.");
            Producent producent3 = new Producent("V&S VIN & SPRIT", "Årstaängsvägen 19a, 117 97,  Stockholm", Country.Sweden);
            list.Add(producent1);
            list.Add(producent2);
            list.Add(producent3);
        }

        public bool Add(Producent obj)
        {
            GetAll().Add(obj);
            return true;
        }

        public List<Producent> GetAll() => list;

        public Producent GetById(uint id)
        {
            return GetAll().FirstOrDefault(obj => obj.Id == id);
        }

        public List<Producent> GetByName(string name)
        {
            List<Producent> returnList = new List<Producent>();
            foreach(Producent producent in list)
            {
                if(producent.Name.Equals(name))
                {
                    returnList.Add(producent);
                }
            }
            return returnList;
        }

        public bool Remove(uint id)
        {
            return GetAll().RemoveAll(obj => obj.Id == id) > 0;
        }

        public Producent Update(Producent obj)
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
