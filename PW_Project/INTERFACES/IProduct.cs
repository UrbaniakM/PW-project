// dlls
using Urbaniak.PW_project.CORE;

namespace Urbaniak.PW_project.INTERFACES
{
    public interface IProduct
    {
        string ToString();

        Country Country { get; set; }

        int Size { get; set; }

        string Name { get; set; }

        string Mark { get; set; }

        uint Id { get; set; }
    }
}
