﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Simplex.Pizzaria.Models
{
    public class estado : SimpleX.Model.estadoCore
    {
        public empresa empresa { get; set; }    
    }
}
