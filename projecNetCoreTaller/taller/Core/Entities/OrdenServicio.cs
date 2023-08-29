using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class OrdenServicio : BaseEntity
    {
        
        public int NroOrden {get; set;}
        public int IdClienteFk {get; set;}
        public Cliente? Cliente { get; set; }
        public DateTime FechaOrden {get; set;}
        public string? DiagnosticoCliente {get; set;}
        public int IdMecanicoFk {get; set;}
        public Mecanico? Mecanico {get;set;}
        public string? DiagnosticoExperto {get; set;}
        public ICollection<OrdenAprobacion>? OrdenesAprobacion {get;set;}
    }
}