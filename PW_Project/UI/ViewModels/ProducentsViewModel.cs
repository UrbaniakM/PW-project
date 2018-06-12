using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urbaniak.PW_project.CORE;
using Urbaniak.PW_project.INTERFACES;

namespace Urbaniak.PW_project.UI.ViewModels
{
    public class ProducentsViewModel
    {
        private readonly IProducentsBL _producentsBL;

        public List<Producent> Producents => _producentsBL.GetAll();
        public Producent CurrentProducent { get; set; }

        public ProducentsViewModel(IProducentsBL producentsBL)
        {
            _producentsBL = producentsBL;
        }
    }
}
