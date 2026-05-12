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
    public partial class CP_Login : Form
    {
        public CP_Login()
        {
            InitializeComponent();
        }

        private void CP_Login_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_Ingresar_Click(object sender, EventArgs e)
        {
            CP_Bienvenida nuevaPantalla = new CP_Bienvenida();
            nuevaPantalla.Show();


            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro nuevaPantalla = new Registro();
            nuevaPantalla.Show();
            this.Hide();
        }
    }
}
