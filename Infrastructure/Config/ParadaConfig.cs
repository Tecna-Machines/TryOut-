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
    public class ParadaConfig : IEntityTypeConfiguration<Parada>
    {
        public void Configure(EntityTypeBuilder<Parada> builder)
        {
            builder.HasKey(p => p.NumParada);
        }
    }
}
