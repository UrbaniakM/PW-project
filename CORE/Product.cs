namespace Urbaniak.PW_project.CORE
{
    public class Product
    {
        private string _name;
        // name of the product
        private Country _country;
        // country of origin of the product
        private int _size;
        // size in ml
        private string _mark;
        // mark of the product
        private static int _numberOfProducts;

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

        static Product()
        {
            _numberOfProducts = 0;
        }

        public Product(string name, string mark, Country country, int size)
        {
            _name = name;
            _mark = mark;
            _country = country;
            _size = size;
            _numberOfProducts++;
        }

        public Product(string name, string mark) : this(name, mark, Country.Poland, 500)
        { }


        public override string ToString() 
        {
            return _mark + ", " + _name + " " + _size.ToString() + " [ml], " + _country.ToString() ;
        }

    }
}