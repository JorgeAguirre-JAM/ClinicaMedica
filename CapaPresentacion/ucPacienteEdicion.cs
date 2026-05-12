using CapaEntities;
using CapaLogic;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class ucPacienteEdicion : UserControl
    {
      
        private int idPacienteActual;
        public event EventHandler RegistroGuardado;

        public ucPacienteEdicion()
        {
            InitializeComponent();
            bt_ediguardar.Click += bt_ediguardar_Click;
        }

       
        public void CargarDatosEdicion(int id, string nombre, string apellidos, string telefono, DateTime fechaNac, string direccion, string tipoSangre)
        {
            idPacienteActual = id;
            tb_edinombre.Text = nombre;
            tb_ediapellido.Text = apellidos;
            tb_editelefono.Text = telefono;
            tb_edidireccion.Text = direccion;
            cb_editipodangre.Text = tipoSangre;

            
            if (fechaNac >= dtp_edifechanac.MinDate && fechaNac <= dtp_edifechanac.MaxDate)
            {
                dtp_edifechanac.Value = fechaNac;
            }
            else
            {
                dtp_edifechanac.Value = DateTime.Now;
            }
        }

        private void bt_ediguardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_edinombre.Text) || string.IsNullOrWhiteSpace(tb_ediapellido.Text))
            {
                MessageBox.Show("El nombre y apellido son obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
               
                CE_Paciente paciente = new CE_Paciente
                {
                    IdPaciente = idPacienteActual,
                    Nombre = tb_edinombre.Text.Trim(),
                    Apellidos = tb_ediapellido.Text.Trim(),
                    Telefono = tb_editelefono.Text.Trim(),
                    Direccion = tb_edidireccion.Text.Trim(),
                    TipoSangre = cb_editipodangre.Text,
                 
                    FechNac = dtp_edifechanac.Value.ToString("yyyy-MM-dd")
                };

                CL_Paciente objNegocio = new CL_Paciente();

                
                bool exito = objNegocio.UpdPaciente(paciente);

                if (exito)
                {
                    MessageBox.Show("Datos actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                 
                    RegistroGuardado?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("No se guardaron los cambios. Verifica la base de datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}