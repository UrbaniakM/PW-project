namespace Urbaniak.PW_project.CORE
{
    public class Producent
    {
        // id of the producer
        private readonly uint _id;
        // name of the producer
        private readonly string _name;
        // address of the producer
        private readonly string _address;
        // country of the producer
        private readonly Country _country;
        private static uint _numberOfProducers;

        public uint Id
        {
            get
            {
                return _id;
            }
        }

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
            _numberOfProducers = 0;
        }

        public Producent(uint id, string name, string address, Country country)
        {
            _id = id;
            _name = name;
            _address = address;
            _country = country;
            _numberOfProducers++;
        }

        public Producent(string name, string address, Country country) : this(_numberOfProducers, name, address, country)
        { }

        public Producent(string name, string address) : this(name, address, Country.Poland)
        { }

        public override string ToString()
        {
            return _name + ", " + _address + ", " + _country.ToString();
        }
    }
}