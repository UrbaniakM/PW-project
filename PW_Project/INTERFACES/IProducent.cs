// dlls
using Urbaniak.PW_project.CORE;

namespace Urbaniak.PW_project.INTERFACES
{
    public interface IProducent
    {
        uint Id { get; set; }

        string Name { get; set; }

        string Address { get; set; }

        Country Country { get; set; }
    }
}
