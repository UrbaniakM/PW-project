using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urbaniak.PW_project.CORE;
using Urbaniak.PW_project.INTERFACES;

namespace Urbaniak.PW_project.UI.ViewModels
{
    public class ProductsListViewModel : ListViewModelBase<Product, ProductViewModel>
    {
        public ProductsListViewModel(IProductsBL _objBL) : base(_objBL)
        { }

        protected override void UpdateList()
        {
            List.Clear();
            _objBL.GetAll().ForEach(obj => List.Add(new ProductViewModel(obj)));
            OnPropertyChanged(nameof(List));
        }

        protected override void CreateObject()
        {
            _previous = Current;
            Current = new ProductViewModel(List.Max(u => u.Id) + 1);
            Current.Validate();
            IsEdited = true;
            OnPropertyChanged(nameof(IsEdited));
            OnPropertyChanged(nameof(Current));
        }

        protected override void Edit()
        {
            _previous = Current;
            Current = new ProductViewModel(Current);
            Current.Validate();
            IsEdited = true;
            OnPropertyChanged(nameof(IsEdited));
            OnPropertyChanged(nameof(Current));
        }

        protected override void Remove()
        {
            bool success = _objBL.Remove(Current.Id);
            if(!success)
            {
                return;
            }
            Current = null;
            UpdateList();
        }

        protected override void SaveChanges()
        {
            if (List.Any(obj => obj.Id == Current.Id))
            {
                _objBL.Update(Current);
            }
            else
            {
                _objBL.Add(Current);
            }
            IsEdited = false;
            OnPropertyChanged(nameof(IsEdited));
            UpdateList();
        }

        protected override void Cancel()
        {
            IsEdited = false;
            Current = _previous;
            OnPropertyChanged(nameof(IsEdited));
        }
    }
}
