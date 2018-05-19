namespace Urbaniak.PW_project.CORE
{
    public class Producent
    {
        // name of the producent
        private readonly string _name;
        // address of the producent
        private readonly string _address;
        // country of the producent
        private readonly Country _country;
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

        public Country Country
        {
            get
            {
                return _country;
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