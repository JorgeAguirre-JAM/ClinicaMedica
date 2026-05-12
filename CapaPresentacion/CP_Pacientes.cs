using CapaDatos;
using CapaLogic;
using FontAwesome.Sharp;
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
    public partial class CP_Pacientes : Form
    {
        private CL_Paciente objPacienteNegocio = new CL_Paciente();
        public CP_Pacientes()
        {
            InitializeComponent();
     
            ConfigurarDisenoTabla();
            AgregarColumnasAcciones();

            txtBuscar.TextChanged += txtBuscar_TextChanged;
            dgvPacientes.DataBindingComplete += dgvPacientes_DataBindingComplete;
        }

        private void CP_Pacientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void dgvPacientes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            if (dgvPacientes.Columns.Contains("Nombre")) dgvPacientes.Columns["Nombre"].DisplayIndex = 0;
            if (dgvPacientes.Columns.Contains("Apellidos")) dgvPacientes.Columns["Apellidos"].DisplayIndex = 1;
            if (dgvPacientes.Columns.Contains("TipoSangre")) dgvPacientes.Columns["TipoSangre"].DisplayIndex = 2;
            if (dgvPacientes.Columns.Contains("Telefono")) dgvPacientes.Columns["Telefono"].DisplayIndex = 3;
            if (dgvPacientes.Columns.Contains("FechNac")) dgvPacientes.Columns["FechNac"].DisplayIndex = 4;

            if (dgvPacientes.Columns.Contains("Direccion")) dgvPacientes.Columns["Direccion"].DisplayIndex = 5;


            ConfigurarBotonesAccion();

            if (dgvPacientes.Columns.Contains("FechNac"))
            {
                dgvPacientes.Columns["FechNac"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            ConfigurarBotonesAccion();
        }

        private void CargarDatos()
        {
            try
            {
                var lista = objPacienteNegocio.ObtenerTodos();
                dgvPacientes.DataSource = null;
                dgvPacientes.DataSource = lista;

                if (dgvPacientes.Columns.Count > 0)
                {

                    if (dgvPacientes.Columns.Contains("IdPaciente"))
                        dgvPacientes.Columns["IdPaciente"].Visible = false;
                    if (dgvPacientes.Columns.Contains("Nombre"))
                        dgvPacientes.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                    if (dgvPacientes.Columns.Contains("Apellidos"))
                        dgvPacientes.Columns["Apellidos"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    if (dgvPacientes.Columns.Contains("Direccion"))
                        dgvPacientes.Columns["Direccion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    if (dgvPacientes.Columns.Contains("FechNac"))
                        dgvPacientes.Columns["FechNac"].DefaultCellStyle.Format = "dd/MM/yyyy";

                    ConfigurarBotonesAccion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ConfigurarBotonesAccion()
        {
            if (dgvPacientes.Columns.Contains("EDITAR") && dgvPacientes.Columns.Contains("ELIMINAR"))
            {

                int ultimaPosicion = dgvPacientes.Columns.Count - 1;


                dgvPacientes.Columns["EDITAR"].DisplayIndex = ultimaPosicion - 1;
                dgvPacientes.Columns["ELIMINAR"].DisplayIndex = ultimaPosicion;

                dgvPacientes.Columns["EDITAR"].Width = 40;
                dgvPacientes.Columns["ELIMINAR"].Width = 40;

                dgvPacientes.Columns["EDITAR"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvPacientes.Columns["ELIMINAR"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_paciente_Click(object sender, EventArgs e)
        {

        }


        private void CargarPacientes()
        {
 
            CL_Paciente objNegocio = new CL_Paciente();
            dgvPacientes.DataSource = objNegocio.ObtenerTodos();

            dgvPacientes.Columns["IdPaciente"].Visible = false;
            dgvPacientes.Columns["Nombre"].HeaderText = "Paciente";
        }
        private void ConfigurarDisenoTabla()
        {

            dgvPacientes.BackgroundColor = Color.White;
            dgvPacientes.BorderStyle = BorderStyle.None;
            dgvPacientes.RowHeadersVisible = false;
            dgvPacientes.AllowUserToAddRows = false;
            dgvPacientes.AllowUserToResizeColumns = false;
            dgvPacientes.AllowUserToResizeRows = false;
            dgvPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Colores de encabezado
            dgvPacientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 86, 145);
            dgvPacientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPacientes.EnableHeadersVisualStyles = false;
    
            dgvPacientes.RowTemplate.Height = 45;
            dgvPacientes.DefaultCellStyle.Padding = new Padding(5, 0, 5, 0); 
                                                                             
        }

        private void AgregarColumnasAcciones()

        {
            if (!dgvPacientes.Columns.Contains("EDITAR"))
            {
                DataGridViewImageColumn colEditar = new DataGridViewImageColumn();
                colEditar.Name = "EDITAR";
                colEditar.HeaderText = "";
                colEditar.Image = IconChar.Edit.ToBitmap(Color.FromArgb(0, 86, 145), 24);
                colEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;
                colEditar.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPacientes.Columns.Add(colEditar);

            }

            if (!dgvPacientes.Columns.Contains("ELIMINAR"))
            {
                DataGridViewImageColumn colEliminar = new DataGridViewImageColumn();
                colEliminar.Name = "ELIMINAR";
                colEliminar.HeaderText = "";
                colEliminar.Image = IconChar.TrashAlt.ToBitmap(Color.Crimson, 24);
                colEliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
                colEliminar.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPacientes.Columns.Add(colEliminar);
            }

        }



        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarPacientes(txtBuscar.Text.Trim());

        }

        private void FiltrarPacientes(string filtro)
        {
            var listaCompleta = objPacienteNegocio.ObtenerTodos();

        
            if (string.IsNullOrWhiteSpace(filtro))
            {
                dgvPacientes.DataSource = listaCompleta;
            }
            else
            {
                string filtroLimpio = EliminarTildes(filtro.ToLower());

                var listaFiltrada = listaCompleta.Where(p =>
                    EliminarTildes(p.Nombre.ToLower()).Contains(filtroLimpio) ||
                    EliminarTildes(p.Apellidos.ToLower()).Contains(filtroLimpio) ||
                   
                    p.Telefono.Contains(filtroLimpio)
                ).ToList();

                dgvPacientes.DataSource = listaFiltrada;
            }

       
            if (dgvPacientes.Columns.Count > 0 && dgvPacientes.Columns.Contains("EDITAR") && dgvPacientes.Columns.Contains("ELIMINAR"))
            {
                int ultimo = dgvPacientes.Columns.Count - 1;
                dgvPacientes.Columns["EDITAR"].DisplayIndex = ultimo - 1;
                dgvPacientes.Columns["ELIMINAR"].DisplayIndex = ultimo;
            }
        }
        private string EliminarTildes(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto)) return texto;

           
            string textoNormalizado = texto.Normalize(System.Text.NormalizationForm.FormD);

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            foreach (char c in textoNormalizado)
            {

                System.Globalization.UnicodeCategory categoria = System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c);
                if (categoria != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(c);
                }
            }


            return sb.ToString().Normalize(System.Text.NormalizationForm.FormC);
        }
        public void CargarFormularioEnPanel(UserControl controlHijo)
        {

            panel1.Controls.Clear();
            controlHijo.Dock = DockStyle.Fill;
            panel1.Controls.Add(controlHijo);

    
            panel1.Width = 450;


            if (controlHijo is ucPacienteEdicion ucEdicion)
            {
                ucEdicion.RegistroGuardado += (s, args) =>
                {
                    CargarDatos();     
                    panel1.Width = 0;  
                };
            }
            if (controlHijo is ucPacienteAgregar ucAgregar) 
            {
                ucAgregar.RegistroGuardado += (s, args) =>
                {
                    CargarDatos();     
                    panel1.Width = 0;  
                };
            }
        }

        private void dgvPacientes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
         
            if (e.RowIndex < 0) return;

            
            string nombreColumna = dgvPacientes.Columns[e.ColumnIndex].Name;

           
            int idPaciente = Convert.ToInt32(dgvPacientes.Rows[e.RowIndex].Cells["IdPaciente"].Value);


            if (nombreColumna == "ELIMINAR")
            {
                DialogResult respuesta = MessageBox.Show("¿Estás seguro de que deseas eliminar este paciente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    try
                    {
                  
                        bool exito = objPacienteNegocio.DelPaciente(idPaciente);

                        if (exito)
                        {
                            MessageBox.Show("Paciente eliminado correctamente.");
                            CargarDatos();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("La tabla que está bloqueando el borrado es:\n\n" + ex.Message, "Modo Detective", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            else if (nombreColumna == "EDITAR")
            {

                ucPacienteEdicion ucHijo = new ucPacienteEdicion();


                string nombre = dgvPacientes.Rows[e.RowIndex].Cells["Nombre"].Value?.ToString() ?? "";
                string apellido = dgvPacientes.Rows[e.RowIndex].Cells["Apellidos"].Value?.ToString() ?? "";
                string telefono = dgvPacientes.Rows[e.RowIndex].Cells["Telefono"].Value?.ToString() ?? "";
                string direccion = dgvPacientes.Rows[e.RowIndex].Cells["Direccion"].Value?.ToString() ?? "";
                string tipoSangre = dgvPacientes.Rows[e.RowIndex].Cells["TipoSangre"].Value?.ToString() ?? "";

                DateTime fechaNac = DateTime.Now;
                if (dgvPacientes.Rows[e.RowIndex].Cells["FechNac"].Value != null)
                {
                    DateTime.TryParse(dgvPacientes.Rows[e.RowIndex].Cells["FechNac"].Value.ToString(), out fechaNac);
                }


                ucHijo.CargarDatosEdicion(idPaciente, nombre, apellido, telefono, fechaNac, direccion, tipoSangre);

 
                CargarFormularioEnPanel(ucHijo);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CP_Medico nuevaPantalla = new CP_Medico();
            nuevaPantalla.Show();


            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ucPacienteAgregar ucHijo = new ucPacienteAgregar();
            CargarFormularioEnPanel(ucHijo);
        
    }
    }
}
