using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Urbaniak.PW_project.BL;
using Urbaniak.PW_project.INTERFACES;
using Urbaniak.PW_project.CORE;
using Urbaniak.PW_project.UI.Properties;

namespace Urbaniak.PW_project.UI
{
    public class ConsoleUI
    {
        private BusinessLogic _businessLogic = null;

        public ConsoleUI()
        {
            Properties.Settings settings = new Properties.Settings();
            _businessLogic = new BusinessLogic(settings.DAO_dll_location);
        }
        
        public void PrintProducents()
        {
            Console.WriteLine("Producents:");
            List<IProducent> producents = _businessLogic.ProducentsBL.GetAll();
            foreach (IProducent producent in producents)
            {
                System.Console.WriteLine(producent);
            }
            System.Console.WriteLine("-----------------------");
        }

        public void PrintProducts()
        {
            Console.WriteLine("Products");
            List<IProduct> products = _businessLogic.ProductsBL.GetAll();
            foreach (IProduct product in products)
            {
                System.Console.WriteLine(product);
            }
            System.Console.WriteLine("-----------------------");
        }
    }
}