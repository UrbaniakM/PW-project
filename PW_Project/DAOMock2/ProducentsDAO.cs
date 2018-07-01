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
            Producent producent1 = new Producent("Russkij Standard",
                "World Trade Center, Office 1503a Krasnopresnenskaya Emb., 12, 123610 Moscow",
                Country.Russia
            );
            Producent producent2 = new Producent("Sobieski Trade Sp. z o.o.", "Kołaczkowo 9, 62-230 Witkowo");
            Producent producent3 = new Producent("Pernod Ricard", "Złota 59, 00-120 Warszawa");
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
            foreach (IProducent producent in list)
            {
                if (producent.Name.Equals(name))
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
            if (index >= 0)
            {
                GetAll()[index] = obj;
            }
            return obj;
        }
    }
}