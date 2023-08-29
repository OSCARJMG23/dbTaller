using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class OrdenAprobacionConfiguration : IEntityTypeConfiguration<OrdenAprobacion>
    {
        public void Configure(EntityTypeBuilder<OrdenAprobacion> builder)
        {
            builder.ToTable("persona");

            builder
            .HasOne(p => p.OrdenServicio)
            .WithMany(p =>p.OrdenesAprobacion)
            .HasForeignKey(p => p.NroOrdenFk);

            builder.Property(p => p.Fecha)
            .IsRequired()
            .HasColumnType("Date");
        
        }
    }
}