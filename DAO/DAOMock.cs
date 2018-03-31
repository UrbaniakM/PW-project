using System.Collections.Generic;
using Urbaniak.PW_project.CORE;
using Urbaniak.PW_project.DAO;

namespace Urbaniak.PW_project.DAO
{
    public class DAOMock : IDAO
    {
        public List<Producent> GetProducents()
        {
            List<Producent> list = new List<Producent>();
            Producent producent1 = new Producent("Stock Polska Sp. z o.o.","Spółdzielcza 6, 20-402 Lublin");
            Producent producent2 = new Producent("CEDC International sp. z o.o.", "Kowanowska 48, 64-600, Oborniki Wlkp.");
            Producent producent3 = new Producent("V&S VIN & SPRIT","Årstaängsvägen 19a, 117 97,  Stockholm", Country.Sweden);
            list.Add(producent1);
            list.Add(producent2);
            list.Add(producent3);
            return list;
        }

        public List<Product> GetProducts()
        {
            List<Product> list = new List<Product>();
            Product product1 = new Product("ŻOŁĄDKOWA", "Gorzka Wódka czysta De Luxe");
            Product product2 = new Product("ŻOŁĄDKOWA", "Gorzka Wódka");
            Product product3 = new Product("SOPLICA", "Czysta Wódka");
            Product product4 = new Product("SOPLICA", "Nalewka orzechowa");
            list.Add(product1);
            list.Add(product2);
            list.Add(product3);
            list.Add(product4);
            return list;
        }
    }
}