using CapaDatos;
using CapaEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogic
{
    public class CL_Especialidad
    {
        private CD_Especialidad objDatos = new CD_Especialidad();

        public List<CE_Especialidad> ObtenerTodas()
        {
            return objDatos.ListarEspecialidades();
        }
        public bool AddEspecialidad(string nombre, string descripcion)
        {
            return objDatos.AgregarEspecialidad(nombre, descripcion);
        }
    }
}
