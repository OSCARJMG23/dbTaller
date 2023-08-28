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
    public class OrdenServicioConfiguration : IEntityTypeConfiguration<OrdenServicio>
    {
        public void Configure(EntityTypeBuilder<OrdenServicio> builder)
        {
            builder.ToTable("persona");

            builder.Property(p => p.NroOrden)
            .IsRequired()
            .HasColumnType("int");

            builder
            .HasOne(p => p.Cliente)
            .WithMany(p =>p.OrdenesServicios)
            .HasForeignKey(p => p.IdClienteFk);

            builder.Property(p => p.FechaOrden)
            .IsRequired()
            .HasColumnType("Date");

            builder.Property(p => p.NombreCliente)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(p => p.NumeroPlaca)
            .IsRequired()
            .HasMaxLength(10);

            builder.Property(p => p.Kilometraje)
            .IsRequired()
            .HasColumnType("double");

            builder.Property(p => p.DiagnosticoCliente)
            .IsRequired()
            .HasMaxLength(50);

            builder
            .HasOne(p => p.Mecanico)
            .WithMany(p =>p.OrdenesServicios)
            .HasForeignKey(p => p.IdMecanicoFk);

            builder.Property(p => p.DiagnosticoExperto)
            .IsRequired()
            .HasMaxLength(50);
        }
    }
}