using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

//dlls
using Urbaniak.PW_project.INTERFACES;


namespace Urbaniak.PW_project.BL
{
    public class BusinessLogic
    {
        private IDAO _dao = null;
        public IObjectBL<IProducent> ProducentsBL { get; }
        public IObjectBL<IProduct> ProductsBL { get; }

        public BusinessLogic(string dllLocation)
        {
            _dao = GetDAO(dllLocation);
            ProducentsBL = new ProducentsBL(_dao.ProducentsDAO);
            ProductsBL = new ProductsBL(_dao.ProductsDAO);
        }

        private IDAO GetDAO(string dllLocation)
        {
            Assembly dll = LoadDll(dllLocation);

            List<Type> implementing = (from typeInter in dll.GetTypes()
                               where typeof(IDAO).IsAssignableFrom(typeInter)
                               select typeInter).ToList();

            if(implementing.Count == 0)
            {
                throw new ArgumentException(dllLocation + ": no class implementing IDAO interface.");
            }

            return (IDAO)Activator.CreateInstance(implementing[0], new object[] { });

        }

        private Assembly LoadDll(string dllPath)
        {
            // check if full path, for example C:\\
            if (!dllPath.Contains(":"))
            {
                string directory = Directory.GetParent(@"./").FullName;
                dllPath = Path.Combine(directory, dllPath);
            }

            try
            {
                Assembly dll = Assembly.LoadFile(dllPath);
                return dll;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                throw;
            }
        }

    }
}
