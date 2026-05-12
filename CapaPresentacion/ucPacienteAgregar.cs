using CapaEntities;
using CapaLogic;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class ucPacienteAgregar : UserControl
    {
     
        public event EventHandler RegistroGuardado;

        public ucPacienteAgregar()
        {
            InitializeComponent();
            dtp_aggfechanac.Value = DateTime.Now;
        }

        private void bt_aggguardar_Click_1(object sender, EventArgs e) 
        {
            if (string.IsNullOrWhiteSpace(tb_aggnombre.Text) || string.IsNullOrWhiteSpace(tb_aggapellido.Text))
            {
                MessageBox.Show("Por favor, completa el nombre y el apellido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                CE_Paciente nuevoPaciente = new CE_Paciente
                {
                    IdPaciente = 0, 
                    Nombre = tb_aggnombre.Text.Trim(),
                    Apellidos = tb_aggapellido.Text.Trim(),
                    Telefono = tb_aggtelefono.Text.Trim(),
                    Direccion = tb_aggdireccion.Text.Trim(),
                    TipoSangre = cb_aggtipodangre.Text,
                
                    FechNac = dtp_aggfechanac.Value.ToString("yyyy-MM-dd")
                };

                CL_Paciente objNegocio = new CL_Paciente();
                bool exito = objNegocio.AddPaciente(nuevoPaciente);

                if (exito)
                {
                    MessageBox.Show("Paciente registrado con éxito.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarCampos();

                    RegistroGuardado?.Invoke(this, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            tb_aggnombre.Clear();
            tb_aggapellido.Clear();
            tb_aggtelefono.Clear();
            tb_aggdireccion.Clear();
            cb_aggtipodangre.SelectedIndex = -1;
            dtp_aggfechanac.Value = DateTime.Now;
        }
    }
}