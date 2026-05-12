using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntities
{
    internal class CE_Consulta
    {
        public int IdConsulta { get; set; }
        public int IdCita { get; set; }
        public int IdPaciente { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public string Estudios { get; set; }
        public string RutaDoctos { get; set; }
    }
}
