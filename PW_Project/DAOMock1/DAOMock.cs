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
    public class DAOMock : IDAO
    {
        private IProducentsDAO _producentsDAO = new ProducentsDAO();
        private IProductsDAO _productsDAO = new ProductsDAO();

        public IProducentsDAO ProducentsDAO
        {
            get
            {
                return _producentsDAO;
            }
        }

        public IProductsDAO ProductsDAO
        {
            get
            {
                return _productsDAO;
            }
        }
    }
}