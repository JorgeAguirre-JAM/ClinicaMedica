using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntities
{
    internal class CE_Cita
    {
        public int IdCita { get; set; }
        public int IdPaciente { get; set; }
        public int IdTurno { get; set; }
        public DateTime Fecha { get; set; }
        public string Motivo { get; set; }
        public int Estado { get; set; } // 0 por realizar, 1 realizada, 2 cancelada
    }
}
