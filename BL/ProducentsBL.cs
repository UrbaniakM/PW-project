using System.Collections.Generic;
using Urbaniak.PW_project.INTERFACES;
using Urbaniak.PW_project.CORE;
using Urbaniak.PW_project.DAO;

namespace Urbaniak.PW_project.BL
{
    public class ProducentsBL : IProducentsBL
    {
        private IDAO _dao = new DAOMock();

        public List<Producent> GetProducents()
        {
            return _dao.GetProducents();
        }
    }
}