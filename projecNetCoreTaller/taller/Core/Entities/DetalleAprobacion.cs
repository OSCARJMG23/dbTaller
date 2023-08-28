using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class DetalleAprobacion : BaseEntity
    {
        public string? Repuesto {get; set;}
        public double ValorUnitario {get; set;}
        public int Cantidad {get; set;}
        public string? Estado {get; set;}
        public int IdOrdenAprobacionFk {get; set;}
        public OrdenAprobacion? OrdenAprobacion {get; set;}
    }
}