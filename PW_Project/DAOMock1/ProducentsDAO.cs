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

        public List<Producent> GetAll()
        {
            return list;
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
    }
}
