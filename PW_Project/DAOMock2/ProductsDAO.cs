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
        public List<Product> GetAll()
        {
            List<Product> list = new List<Product>();
            Product product1 = new Product("ŻUBRÓWKA", "Biała wódka");
            Product product2 = new Product("FINLANDIA", "Wódka Clear", Country.Finland);
            Product product3 = new Product("SOPLICA", "Nalewka pigwowa");
            Product product4 = new Product("LUBELSKA","Wiśniówka");
            list.Add(product1);
            list.Add(product2);
            list.Add(product3);
            list.Add(product4);
            return list;
        }
    }
}