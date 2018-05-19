using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urbaniak.PW_project.CORE;
using Urbaniak.PW_project.INTERFACES;

namespace Urbaniak.PW_project.UI.ViewModels
{
    public class ProductsViewModel
    {
        private readonly IProductsBL _productsBL;

        public List<Product> Products => _productsBL.GetAll();
        public Product CurrentProduct { get; set; }

        public ProductsViewModel(IProductsBL productsBL)
        {
            _productsBL = productsBL;
        }
    }
}
