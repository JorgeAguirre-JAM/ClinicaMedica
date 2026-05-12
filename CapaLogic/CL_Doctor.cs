using CapaDatos;
using CapaEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogic
{
    public class CL_Doctor
    {
        private CD_Doctor objDoctorDatos = new CD_Doctor();
        public List<CE_Doctor> ObtenerTodos()
        {
            return objDoctorDatos.ListarDoctor();
        }

  
        public bool AddDoctor(CE_Doctor doctor)
        {
            return objDoctorDatos.AddDoctor(doctor);
        }


        public bool UpdDoctor(CE_Doctor doctor)
        {
            return objDoctorDatos.UpdDoctor(doctor);
        }

 
        public bool DelDoctor(int idDoctor)
        {
            return objDoctorDatos.EliminarDoctorConTurnos(idDoctor);
        }
    }
}
