using CapaDatos;
using CapaEntities;
using System.Collections.Generic;

namespace CapaLogic
{
    public class CL_Paciente
    {
        private CD_Paciente objpacienteDatos = new CD_Paciente();

        public List<CE_Paciente> ObtenerTodos()
        {
            return objpacienteDatos.ListarPacientes();
        }

      
        public bool AddPaciente(CE_Paciente paciente)
        {
            return objpacienteDatos.AddPaciente(paciente);
        }

     
        public bool UpdPaciente(CE_Paciente paciente)
        {
            return objpacienteDatos.UpdPaciente(paciente);
        }

      
        public bool DelPaciente(int idPaciente)
        {
            return objpacienteDatos.DelPaciente(idPaciente);
        }
    }
}