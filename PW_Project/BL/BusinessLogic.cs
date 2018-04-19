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
        public IProducentsBL ProducentsBL { get; }
        public IProductsBL ProductsBL { get; }

        public BusinessLogic()
        {
            _dao = GetDAO();
            ProducentsBL = new ProducentsBL(_dao);
            ProductsBL = new ProductsBL(_dao);
        }

        private IDAO GetDAO()
        {
            Properties.Settings settings = new Properties.Settings();
            string dllPath = settings.DAO_dll_location;
            string daoClassName = settings.DAO_class_name;

            Assembly dll = LoadDll(dllPath);
            Type type = dll.GetType(daoClassName);
            return (IDAO) Activator.CreateInstance(type, new object[] { });

        }

        private Assembly LoadDll(string dllPath)
        {
            // check if full path, for example C:\\
            if(!dllPath.Contains(":"))
            {
                string directory = Directory.GetParent(@"../../../").FullName;
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
