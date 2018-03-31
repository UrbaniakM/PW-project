using System.Collections.Generic;
using Urbaniak.PW_project.CORE;
using Urbaniak.PW_project.DAO;
using Urbaniak.PW_project.INTERFACES;

namespace Urbaniak.PW_project.BL
{
    public class ProductsBL : IProductsBL
    {
        private IDAO _dao = new DAOMock();

        public List<Product> GetProducts()
        {
            return _dao.GetProducts();
        }
    }
}