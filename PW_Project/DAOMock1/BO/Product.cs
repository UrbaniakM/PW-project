//dlls
using Urbaniak.PW_project.CORE;
using Urbaniak.PW_project.INTERFACES;

namespace Urbaniak.PW_project.DAO
{
    public class Product : IProduct
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
        private static uint _numberOfProducts;

        public Country Country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
            }
        }

        public int Size
        {
            get
            {
                return _size;
            }
            set
            {
                _size = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Mark
        {
            get
            {
                return _mark;
            }
            set
            {
                _mark = value;
            }
        }

        public uint Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        static Product()
        {
            _numberOfProducts = 0;
        }

        public Product() { }

        public Product(uint id, string mark, string name, Country country, int size)
        {
            _id = id;
            _name = name;
            _mark = mark;
            _country = country;
            _size = size;
            _numberOfProducts++;
        }

        public Product(string mark, string name, Country country, int size) : this(_numberOfProducts, name, mark, country, size)
        { }

        public Product(string mark, string name) : this(mark, name, Country.Poland, 500)
        { }

        public Product(string mark, string name, Country country) : this(mark, name, country, 500)
        { }

        public override string ToString()
        {
            return _mark + ", " + _name + " " + _size.ToString() + " [ml], " + _country.ToString();
        }

    }
}