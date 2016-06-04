﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SimpleX.Model
{
    public class estado
    {
        [Key]
        public Guid ID { get; set; }
        public string nome { get; set; }
        public string codigo { get; set; }
        public Guid empresaID { get; set; }
    }
}
