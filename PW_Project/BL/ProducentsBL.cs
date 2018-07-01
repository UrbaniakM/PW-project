using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// dlls
using Urbaniak.PW_project.INTERFACES;

namespace Urbaniak.PW_project.BL
{
    internal class ProducentsBL : ObjectBL<IProducent>
    {
        internal ProducentsBL(IDAOObject<IProducent> dao) : base(dao)
        { }
    }
}