namespace Urbaniak.PW_project.CORE
{
    public class Producent
    {
        private readonly string _name;
        // name of the producent
        private readonly string _address;
        // address of the producent
        private readonly Country _country;
        // country of the producent
        private static int _numberOfProducents;

        public string Name 
        {
            get
            {
                return _name;
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }
        }

        static Producent()
        {
            _numberOfProducents = 0;
        }

        public Producent(string name, string address, Country country)
        {
            _name = name;
            _address = address;
            _country = country;
            _numberOfProducents++;
        }

        public Producent(string name, string address) : this(name, address, Country.Poland)
        { }

        public override string ToString()
        {
            return _name + ", " + _address + ", " + _country.ToString();
        }
    }
}