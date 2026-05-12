using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntities
{
    internal class CE_signosvitales
    {
        public int IdSignosVitales { get; set; }
        public int IdConsulta { get; set; }
        public float Temperatura { get; set; }
        public int FrecuenciaCardiaca { get; set; }
        public int FrecuenciaRespiratoria { get; set; }
        public string PresionArterial { get; set; }
        public float Peso { get; set; }
        public float Talla { get; set; }
        public DateTime FechaHoraToma { get; set; }

    }
}
