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
    public class DetalleAprobacionConfiguration : IEntityTypeConfiguration<DetalleAprobacion>
    {
        public void Configure(EntityTypeBuilder<DetalleAprobacion> builder)
        {
            builder.ToTable("persona");


            builder.Property(p => p.Repuesto)
            .IsRequired()
            .HasMaxLength(50);
        
            builder.Property(p => p.ValorUnitario)
            .IsRequired()
            .HasColumnType("double");

            builder.Property(p => p.Cantidad)
            .IsRequired()
            .HasColumnType("int");

            builder.Property(p => p.Estado)
            .IsRequired()
            .HasMaxLength(10);

            builder
            .HasOne(p => p.OrdenAprobacion)
            .WithMany(p =>p.DetallesAprobacions)
            .HasForeignKey(p => p.IdOrdenAprobacionFk);
        }
    }
}