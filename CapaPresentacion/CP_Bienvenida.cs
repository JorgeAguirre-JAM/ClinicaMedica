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
    public partial class CP_Bienvenida : Form
    {
        public CP_Bienvenida()
        {
            InitializeComponent();
        }

        private void tlp_busquedanav_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel_header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_paciente_Click(object sender, EventArgs e)
        {
            CP_Pacientes nuevaPantalla = new CP_Pacientes();
            nuevaPantalla.Show();


            this.Hide();
        }

        private void bt_medico_Click(object sender, EventArgs e)
        {
            CP_Medico nuevaPantalla = new CP_Medico();
            nuevaPantalla.Show();


            this.Hide();
        }
    }
}
