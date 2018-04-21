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

        public List<Producent> GetAll()
        {
            return list;
        }

        public List<Producent> GetByName(string name)
        {
            List<Producent> returnList = new List<Producent>();
            foreach (Producent producent in list)
            {
                if (producent.Name.Equals(name))
                {
                    returnList.Add(producent);
                }
            }
            return returnList;
        }
    }
}