﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urbaniak.PW_project.INTERFACES
{
    public interface IProductsBL
    {
        List<CORE.Product> GetAll();

        List<CORE.Product> GetByName(string name);
    }
}