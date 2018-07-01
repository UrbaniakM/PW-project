﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urbaniak.PW_project.INTERFACES
{
    public interface IDAO
    {
        IProducentsDAO ProducentsDAO { get; }
        IProductsDAO ProductsDAO { get; }
    }
}