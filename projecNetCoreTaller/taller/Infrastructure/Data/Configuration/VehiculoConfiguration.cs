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
    public class VehiculoConfiguration : IEntityTypeConfiguration<Vehiculo>
    {
        public void Configure(EntityTypeBuilder<Vehiculo> builder)
        {
            builder.ToTable("vehiculo");

            builder.Property(p => p.Placa)
            .IsRequired()
            .HasMaxLength(10);

            builder.Property(p => p.Modelo)
            .IsRequired()
            .HasMaxLength(20);

            builder.Property(p => p.Marca)
            .IsRequired()
            .HasMaxLength(25);

            builder.Property(p => p.Color)
            .IsRequired()
            .HasMaxLength(20);

            builder.Property(p => p.Color)
            .IsRequired()
            .HasColumnType("double");

            builder.Property(p => p.FechaRegistro)
            .IsRequired()
            .HasColumnType("Date");

            builder
            .HasOne(p => p.Cliente)
            .WithMany(p =>p.VehiculosCliente)
            .HasForeignKey(p => p.IdClienteFk);

        }
    }
}