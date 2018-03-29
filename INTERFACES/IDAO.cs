using System.Collections.Generic;

namespace Urbaniak.PW_project.DAO
{
    public interface IDAO
    {
        
         List<T> ImportData<T>();
    }
}