using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//dlls
using Urbaniak.PW_project.CORE;

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

        public ProducerViewModel(Producent producer)
        {
            _id = producer.Id;
            _name = producer.Name;
            _address = producer.Address;
            _country = producer.Country;
        }

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
