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
        private List<Product> list;

        internal ProductsDAO()
        {
            list = new List<Product>();
            Product product1 = new Product("ŻOŁĄDKOWA", "Gorzka Wódka czysta De Luxe");
            Product product2 = new Product("ŻOŁĄDKOWA", "Gorzka Wódka");
            Product product3 = new Product("SOPLICA", "Czysta Wódka");
            Product product4 = new Product("SOPLICA", "Nalewka orzechowa");
            list.Add(product1);
            list.Add(product2);
            list.Add(product3);
            list.Add(product4);
        }

        public bool Add(Product obj)
        {
            GetAll().Add(obj);
            return true;
        }

        public List<Product> GetAll() => list;

        public Product GetById(uint id)
        {
            return GetAll().FirstOrDefault(obj => obj.Id == id);
        }

        public List<Product> GetByName(string name)
        {
            List<Product> returnList = new List<Product>();
            foreach (Product product in list)
            {
                if (product.Name.Equals(name))
                {
                    returnList.Add(product);
                }
            }
            return returnList;
        }

        public bool Remove(uint id)
        {
            return GetAll().RemoveAll(obj => obj.Id == id) > 0;
        }

        public bool Update(Product obj)
        {
            int index = GetAll().FindIndex(el => el.Id == obj.Id);
            if (index < 0)
            {
                return false;
            }
            GetAll()[index] = obj;
            return true;
        }
    }
}
