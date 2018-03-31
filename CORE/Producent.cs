namespace Urbaniak.PW_project.CORE
{
    public class Producent
    {
        private string _name;
        // name of the producent
        private string _address;
        // address of the producent
        private Country _country;
        // country of the producent
        private static int _numberOfProducents;

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

        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
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