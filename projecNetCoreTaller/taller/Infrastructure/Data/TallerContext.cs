using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class TallerContext : DbContext
    {
        public TallerContext(DbContextOptions<TallerContext> options) : base(options)
        {
        }
        public DbSet<Persona>? Personas {get; set;}
        public DbSet<TipoPersona>? TiposPersonas {get; set;}
        public DbSet<Cliente>? Clientes {get; set;}
        public DbSet<Vehiculo>? Vehiculos {get; set;}
        public DbSet<Mecanico>? Mecanicos {get; set;}
        public DbSet<OrdenServicio>? OrdenesServicios {get; set;}
        public DbSet<OrdenAprobacion>? OrdenesAprobacion {get; set;}
        public DbSet<DetalleAprobacion>? DetallesAprobacion {get; set;}
    }
}