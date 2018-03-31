using System;
using System.Collections.Generic;
using Urbaniak.PW_project.BL;
using Urbaniak.PW_project.INTERFACES;
using Urbaniak.PW_project.CORE;

namespace Urbaniak.PW_project.UI
{
    public class ConsoleUI
    {
        private IProducentsBL _producentsBL = new ProducentsBL();
        private IProductsBL _productsBL = new ProductsBL();

        public void PrintProducents()
        {
            Console.WriteLine("Producents:");
            List<Producent> producents = _producentsBL.GetProducents();
            foreach(Producent producent in producents)
            {
                System.Console.WriteLine(producent);
            }
            System.Console.WriteLine("-----------------------");
        }

        public void PrintProducts()
        {
            Console.WriteLine("Products");
            List<Product> products = _productsBL.GetProducts();
            foreach(Product product in products)
            {
                System.Console.WriteLine(product);
            }
            System.Console.WriteLine("-----------------------");
        }
    }
}