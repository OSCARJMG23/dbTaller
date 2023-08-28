using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class TipoPersona : BaseEntity
    {
        public string? Descripcion { get; set; }
        public ICollection<Persona>? Personas {get;set;}
        public ICollection<Cliente>? Clientes {get;set;}
        public ICollection<Mecanico>? Mecanicos {get;set;}
    }
}