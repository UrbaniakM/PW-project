﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Urbaniak.PW_project.BL;
using Urbaniak.PW_project.INTERFACES;
using Urbaniak.PW_project.CORE;

namespace Urbaniak.PW_project.UI
{
    public class ConsoleUI
    {
        private BusinessLogic _businessLogic = new BusinessLogic();

        public void PrintProducents()
        {
            Console.WriteLine("Producents:");
            List<Producent> producents = _businessLogic.ProducentsBL.GetAll();
            foreach (Producent producent in producents)
            {
                System.Console.WriteLine(producent);
            }
            System.Console.WriteLine("-----------------------");
        }

        public void PrintProducts()
        {
            Console.WriteLine("Products");
            List<Product> products = _businessLogic.ProductsBL.GetAll();
            foreach (Product product in products)
            {
                System.Console.WriteLine(product);
            }
            System.Console.WriteLine("-----------------------");
        }
    }
}