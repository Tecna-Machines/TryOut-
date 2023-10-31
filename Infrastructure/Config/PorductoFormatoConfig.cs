﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Config
{
    public class ProductoFormatoConfig : IEntityTypeConfiguration<ProductoFormato>
    {
        public void Configure(EntityTypeBuilder<ProductoFormato> builder)
        {
            builder.HasKey(pf => new{ pf.NombreProducto,pf.DescripcionFormato});

            builder.HasOne(pf => pf.Producto)
                .WithMany(p => p.ProductosFormatos)
                .HasForeignKey(pf => pf.NombreProducto);

            builder.HasOne(pf => pf.Formato)
                .WithMany(f => f.ProductosFormatos)
                .HasForeignKey(pf => pf.DescripcionFormato);
        }
    }
}
