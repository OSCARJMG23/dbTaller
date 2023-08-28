using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Persona : BaseEntity
    {
        public int TipoPersonaFk { get; set; }
        public TipoPersona? TipoPersona { get; set; }
    }
}