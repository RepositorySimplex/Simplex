﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using SimpleX.Model;

namespace SimpleX.ModelCore.Mapping
{
    public class compraMap : EntityTypeConfiguration<compra>
    {
        public compraMap()
        {
            this.ToTable("compra");
            this.Property(c => c.ID).HasColumnName("ID");
            this.Property(c => c.numeroPedido).HasColumnName("numeroPedido");
            this.Property(c => c.valorTotal).HasColumnName("valorTotal");
            this.Property(c => c.compraStatusID).HasColumnName("compraStatusID");
            this.Property(c => c.empresaID).HasColumnName("empresaID");
        }
    }
}
