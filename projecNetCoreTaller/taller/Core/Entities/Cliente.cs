using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Cliente : BaseEntity
    {
        public string? Cedula {get; set;}
        public string? Nombre {get; set;}
        public string? Apellido {get; set;}
        public string? Telefono {get; set;}
        public string? Email {get; set;}
        public DateTime FechaRegistro {get; set;} 
        public ICollection<Vehiculo>? VehiculosCliente {get;set;}
        public int IdTipoPersonaFk {get; set;}
        public TipoPersona? TipoPersona { get; set; }
        public ICollection<OrdenServicio>? OrdenesServicios {get;set;}
    }
}