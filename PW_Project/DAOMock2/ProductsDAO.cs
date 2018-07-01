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
    internal class ProductsDAO : IProductsDAO
    {
        private List<IProduct> list;

        internal ProductsDAO()
        {
            list = new List<IProduct>();
            Product product1 = new Product("ŻUBRÓWKA", "Biała wódka");
            Product product2 = new Product("FINLANDIA", "Wódka Clear", Country.Finland);
            Product product3 = new Product("SOPLICA", "Nalewka pigwowa");
            Product product4 = new Product("LUBELSKA", "Wiśniówka");
            list.Add(product1);
            list.Add(product2);
            list.Add(product3);
            list.Add(product4);
        }

        public bool Add(IProduct obj)
        {
            GetAll().Add(obj);
            return true;
        }

        public List<IProduct> GetAll() => list;

        public IProduct GetById(uint id)
        {
            return GetAll().FirstOrDefault(obj => obj.Id == id);
        }

        public List<IProduct> GetByName(string name)
        {
            List<IProduct> returnList = new List<IProduct>();
            foreach (IProduct product in list)
            {
                if (product.Name.Equals(name))
                {
                    returnList.Add(product);
                }
            }
            return returnList;
        }

        public IProduct CreateNewObj()
        {
            return new Product();
        }

        public bool Remove(uint id)
        {
            return GetAll().RemoveAll(obj => obj.Id == id) > 0;
        }

        public IProduct Update(IProduct obj)
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