﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogService.Models.Dbo
{
    public class CType : IObjectWithId
    {
        public long Id { get; set; }
        public string Type { get; set; }

    }
}
