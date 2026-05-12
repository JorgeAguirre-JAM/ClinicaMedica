using CapaLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class ucEspecialidadAgregar : UserControl
    {
        public event EventHandler RegistroGuardado;
        public ucEspecialidadAgregar()
        {
            InitializeComponent();
        }

        private void bt_guardaresp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_aggenombreesp.Text))
            {
                MessageBox.Show("El nombre de la especialidad es obligatorio.");
                return;
            }

            try
            {
                CL_Especialidad objLogica = new CL_Especialidad();
                bool exito = objLogica.AddEspecialidad(tb_aggenombreesp.Text.Trim(), tb_aggdescresp.Text.Trim());

                if (exito)
                {
                    MessageBox.Show("Especialidad guardada correctamente.");

                  
                    RegistroGuardado?.Invoke(this, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
