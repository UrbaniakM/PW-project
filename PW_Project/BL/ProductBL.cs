using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// dlls
using Urbaniak.PW_project.INTERFACES;
using Urbaniak.PW_project.CORE;

namespace Urbaniak.PW_project.BL
{
    internal class ProductsBL : ObjectBL<Product>, IProductsBL
    {
        internal ProductsBL(IProductsDAO dao) : base(dao)
        { }
    }
}
