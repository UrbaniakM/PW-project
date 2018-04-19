using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//dlls
using Urbaniak.PW_project.INTERFACES;
using Urbaniak.PW_project.DAO;

namespace Urbaniak.PW_project.BL
{
    public class BusinessLogic
    {
        private IDAO _dao = null;
        public IProducentsBL ProducentsBL { get; }
        public IProductsBL ProductsBL { get; }

        public BusinessLogic()
        {
            _dao = new DAOMock();
            ProducentsBL = new ProducentsBL(_dao);
            ProductsBL = new ProductsBL(_dao);
        }

    }
}
