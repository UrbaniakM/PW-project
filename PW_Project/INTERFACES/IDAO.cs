using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urbaniak.PW_project.INTERFACES
{
    public interface IDAO
    {

        List<CORE.Producent> GetProducents();

        List<CORE.Product> GetProducts();

    }
}