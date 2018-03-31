using System;
using Urbaniak.PW_project.BL;
using Urbaniak.PW_project.INTERFACES;

namespace Urbaniak.PW_project.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleUI consoleUI = new ConsoleUI();
            consoleUI.PrintProducents();
            consoleUI.PrintProducts();
        }
    }
}
