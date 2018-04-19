using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// dlls
using Urbaniak.PW_project.INTERFACES;
using Urbaniak.PW_project.CORE;
using Urbaniak.PW_project.DAO;

namespace Urbaniak.PW_project.BL
{
    public class ProductsBL : IProductsBL
    {
        private IProductsDAO _productsDAO = null;

        public ProductsBL(IDAO dao)
        {
            _productsDAO = dao.ProductsDAO;
        }

        public List<Product> GetAll()
        {
            return _productsDAO.GetAll();
        }
    }
}
