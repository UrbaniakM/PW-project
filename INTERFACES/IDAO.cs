using System.Collections.Generic;
using Urbaniak.PW_project.CORE;

namespace Urbaniak.PW_project.DAO
{
    public interface IDAO
    {
        
         List<Producent> GetProducents();

         List<Product> GetProducts();

    }
}