﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// dlls
using Urbaniak.PW_project.INTERFACES;
using Urbaniak.PW_project.CORE;

namespace Urbaniak.PW_project.BL
{
    internal class ProductsBL : IProductsBL
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

        public List<Product> GetByName(string name)
        {
            return _productsDAO.GetByName(name);
        }
    }
}
