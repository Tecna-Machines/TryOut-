using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Config
{
    public class FormatoConfig : IEntityTypeConfiguration<Formato>
    {
        public void Configure(EntityTypeBuilder<Formato> builder)
        {
            builder.HasKey(f => f.DescripcionFormato);
        }
    }
}
