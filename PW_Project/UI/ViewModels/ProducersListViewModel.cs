﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//dlls
using Urbaniak.PW_project.CORE;
using Urbaniak.PW_project.INTERFACES;

namespace Urbaniak.PW_project.UI.ViewModels
{
    public class ProducersListViewModel : ListViewModelBase<IProducent, ProducerViewModel>
    {
        public ProducersListViewModel(IObjectBL<IProducent> _objBL) : base(_objBL)
        { }

        protected override void UpdateList()
        {
            List.Clear();
            _objBL.GetAll().ForEach(obj => List.Add(new ProducerViewModel(obj)));
            OnPropertyChanged(nameof(List));
        }

        protected override void CreateObject()
        {
            _previous = Current;
            Current = new ProducerViewModel(List.Max(u => u.Id) + 1);
            Current.Validate();
            IsEdited = true;
        }

        protected override void Edit()
        {
            _previous = Current;
            Current = new ProducerViewModel(Current);
            Current.Validate();
            IsEdited = true;
        }

        protected override void Remove()
        {
            bool success = _objBL.Remove(Current.Id);
            if (!success)
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
                _objBL.Update(ConvertCurrent());
            }
            else
            {
                _objBL.Add(ConvertCurrent());
            }
            IsEdited = false;
            UpdateList();
        }

        protected IProducent ConvertCurrent()
        {
            IProducent zm = _objBL.CreateNewObj();
            zm.Id = Current.Id;
            zm.Name = Current.Name;
            zm.Address = Current.Address;
            zm.Country = Current.Country;
            return zm;
        }

        protected override void Cancel()
        {
            IsEdited = false;
            Current = _previous;
        }
    }
}
