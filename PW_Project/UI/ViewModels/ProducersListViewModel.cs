using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//dlls
using Urbaniak.PW_project.CORE;
using Urbaniak.PW_project.INTERFACES;

namespace Urbaniak.PW_project.UI.ViewModels
{
    public class ProducersListViewModel : ListViewModelBase<Producent>
    {
        public ProducersListViewModel(IProducentsBL _objBL) : base(_objBL)
        { }

        protected override void CreateObject()
        {
            throw new NotImplementedException();
        }

        protected override void Edit()
        {
            throw new NotImplementedException();
        }

        protected override void Remove()
        {
            throw new NotImplementedException();
        }

        protected override void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
