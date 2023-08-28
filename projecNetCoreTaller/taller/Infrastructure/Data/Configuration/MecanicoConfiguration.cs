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
    public class MecanicoConfiguration : IEntityTypeConfiguration<Mecanico>
    {
        public void Configure(EntityTypeBuilder<Mecanico> builder)
        {
            builder.ToTable("mecanico");

            builder.Property(p => p.Cedula)
            .IsRequired()
            .HasMaxLength(20);
            
            builder.Property(p => p.Nombre)
            .IsRequired()
            .HasMaxLength(50);
            
            builder.Property(p => p.Apellido)
            .IsRequired()
            .HasMaxLength(50);
            
            builder.Property(p => p.Telefono)
            .IsRequired()
            .HasMaxLength(15);
            
            builder.Property(p => p.Email)
            .IsRequired()
            .HasMaxLength(35);
            
            builder.Property(p => p.Especialidad)
            .IsRequired()
            .HasMaxLength(35);

            builder
            .HasOne(p => p.TipoPersona)
            .WithMany(p =>p.Mecanicos)
            .HasForeignKey(p => p.IdTipoPersonaFk);
        }
    }
}