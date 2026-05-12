using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntities
{
    public class CE_Doctor
    {
        public int IdDoctor { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public int IdEspecialidad { get; set; }
        public string NumeroColegiado { get; set; }
        public string RutaDoctos { get; set; }
        public string NombreEspecialidad { get; set; }
    }
}
