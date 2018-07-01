//dlls
using Urbaniak.PW_project.CORE;
using Urbaniak.PW_project.INTERFACES;

namespace Urbaniak.PW_project.DAO
{
    public class Producent : IProducent
    {
        // id of the producer
        private uint _id;
        // name of the producer
        private string _name;
        // address of the producer
        private string _address;
        // country of the producer
        private Country _country;
        private static uint _numberOfProducers;

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

        static Producent()
        {
            _numberOfProducers = 0;
        }

        public Producent() { }

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
