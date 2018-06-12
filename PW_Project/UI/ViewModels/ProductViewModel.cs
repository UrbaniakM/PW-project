using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

//dlls
using Urbaniak.PW_project.CORE;

namespace Urbaniak.PW_project.UI.ViewModels
{
    public class ProductViewModel : ViewModelBase
    {
        // id of the product
        private uint _id;
        // name of the product
        private string _name;
        // country of origin of the product
        private Country _country;
        // size in ml
        private int _size;
        // mark of the product
        private string _mark;

        public List<Country> Countries => Enum.GetValues(typeof(Country)).Cast<Country>().ToList();

        public ProductViewModel(Product product)
        {
            _id = product.Id;
            _name = product.Name;
            _country = product.Country;
            _size = product.Size;
            _mark = product.Mark;
        }

        public ProductViewModel(uint id)
        {
            _id = id;
        }

        #region Conversions

        public ProductViewModel(ProductViewModel product)
        {
            _id = product.Id;
            _name = product.Name;
            _country = product.Country;
            _size = product.Size;
            _mark = product.Mark;
        }

        public static implicit operator Product(ProductViewModel model)
        {
            return new Product(model.Id, model.Mark, model.Name, model.Country, model.Size);
        }

        #endregion

        #region Properties

        //[Display(Name="Country")]
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

        [Required(ErrorMessage = "Size is required")]
        [Range(100, 2020, ErrorMessage = "Size must be in range from 100 to 2000 ml")]
        public int Size
        {
            get { return _size; }
            set
            {
                _size = value;
                OnPropertyChanged(nameof(Size));
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

        [Required(ErrorMessage = "Mark is required")]
        public string Mark
        {
            get { return _mark; }
            set
            {
                _mark = value;
                OnPropertyChanged(nameof(Mark));
                Validate();
            }
        }

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

        #endregion
    }
}
