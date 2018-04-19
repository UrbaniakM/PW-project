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
    public class ProducentsBL : IProducentsBL
    {
        private IProducentsDAO _producentsDAO = null; 

        public ProducentsBL(IDAO dao)
        {
            _producentsDAO = dao.ProducentsDAO;
        }

        public List<Producent> GetAll()
        {
            return _producentsDAO.GetAll();
        }
    }
}