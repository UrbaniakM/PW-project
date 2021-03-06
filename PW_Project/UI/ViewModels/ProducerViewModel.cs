﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

//dlls
using Urbaniak.PW_project.CORE;
using Urbaniak.PW_project.INTERFACES;

namespace Urbaniak.PW_project.UI.ViewModels
{
    public class ProducerViewModel : ViewModelBase
    {
        // id of the producer
        private uint _id;
        // name of the producer
        private string _name;
        // address of the producer
        private string _address;
        // country of the producer
        private Country _country;

        public List<Country> Countries => Enum.GetValues(typeof(Country)).Cast<Country>().ToList();

        public ProducerViewModel(IProducent producer)
        {
            _id = producer.Id;
            _name = producer.Name;
            _address = producer.Address;
            _country = producer.Country;
        }

        public ProducerViewModel(uint id)
        {
            _id = id;
        }

        #region Conversions

        public ProducerViewModel(ProducerViewModel old)
        {
            _id = old.Id;
            _name = old.Name;
            _address = old.Address;
            _country = old.Country;
        }

        /*public static implicit operator Producent(ProducerViewModel model)
        {
            return new Producent(model.Id, model.Name, model.Address, model.Country);
        }*/

        #endregion

        #region Properties

        public uint Id
        {
            get { return _id; }
            set 
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
                Validate();
            }
        }

        [Required(ErrorMessage = "Name is required")]
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
                Validate();
            }
        }

        [Required(ErrorMessage = "Address is required")]
        public string Address
        {
            get { return _address; }
            set
            {
                _address = value;
                OnPropertyChanged(nameof(Address));
                Validate();
            }
        }

        [Required(ErrorMessage = "Country is required")]
        public Country Country
        {
            get { return _country; }
            set
            {
                _country = value;
                OnPropertyChanged(nameof(Country));
                Validate();
            }
        }

        #endregion
    }
}
