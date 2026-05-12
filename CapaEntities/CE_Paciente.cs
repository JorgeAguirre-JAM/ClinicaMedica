using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaEntities
{
    public class CE_Paciente
    {
        public CE_Paciente() { }

            public int IdPaciente { get; set; }
            public string Nombre { get; set; }
            public string Apellidos { get; set; }
            public string Telefono { get; set; }
            public String TipoSangre { get; set; }
            public String Direccion {  get; set; }
            public String FechNac {  get; set; }
        }

}
