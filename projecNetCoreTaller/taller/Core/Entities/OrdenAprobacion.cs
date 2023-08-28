using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class OrdenAprobacion : BaseEntity
    {
        public int NroOrdenFk {get; set;}
        public OrdenServicio? OrdenServicio {get; set;}
        public DateTime Fecha {get; set;}
        public int IdEmpleadoFk {get; set;}
        public Mecanico? Mecanico {get; set;}
        public int IdDetalleFk {get; set;}
        public ICollection<DetalleAprobacion>? DetallesAprobacions {get;set;}
    }
}