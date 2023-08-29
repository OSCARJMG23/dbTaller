using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class MecanicoOrdenServicio
    {
        public int IdMecanicoFk {get; set;}
        public Mecanico? Mecanico;
        public int NroOrdenFk {get; set;}
        public OrdenServicio? OrdenServicio;
    }
}