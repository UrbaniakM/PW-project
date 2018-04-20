namespace Urbaniak.PW_project.CORE
{
    public class Product
    {
        // name of the product
        private readonly string _name;
        // country of origin of the product
        private readonly Country _country;
        // size in ml
        private readonly int _size;
        // mark of the product
        private readonly string _mark;
        private static int _numberOfProducts;

        public Country Country
        {
            get
            {
                return _country;
            }
        }

        public int Size
        {
            get
            {
                return _size;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string Mark
        {
            get
            {
                return _mark;
            }
        }

        static Product()
        {
            _numberOfProducts = 0;
        }

        public Product(string mark, string name, Country country, int size)
        {
            _name = name;
            _mark = mark;
            _country = country;
            _size = size;
            _numberOfProducts++;
        }

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