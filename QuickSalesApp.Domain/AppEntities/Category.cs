﻿using QuickSalesApp.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSalesApp.Domain.AppEntities
{
    public class Category : EntityBase
    {
        public string Name { get; set; }

        public string Description { get; set; }


    }
}
