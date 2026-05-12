using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntities
{
    internal class CE_Turno
    {
        public int IdTurno { get; set; }
        public int IdDoctor { get; set; }
        public string Dia { get; set; }
        public string Horario { get; set; }
        public int Estado { get; set; } // 0 disponible, 1 ocupado
    }
}
