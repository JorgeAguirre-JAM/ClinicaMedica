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
    public partial class CP_Medico : Form
    {
        private CL_Doctor objDoctorNegocio = new CL_Doctor();

        public CP_Medico()
        {
            InitializeComponent();
            ConfigurarDisenoTabla();
            AgregarColumnasAcciones();

            txtBuscar.TextChanged += txtBuscar_TextChanged;
            dgvMedico.DataBindingComplete += dgvMedico_DataBindingComplete;
        }

        private void CP_Medico_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void dgvMedico_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvMedico.Columns.Contains("Nombre")) dgvMedico.Columns["Nombre"].DisplayIndex = 0;
            if (dgvMedico.Columns.Contains("Apellidos")) dgvMedico.Columns["Apellidos"].DisplayIndex = 1;
            if (dgvMedico.Columns.Contains("Telefono")) dgvMedico.Columns["Telefono"].DisplayIndex = 2;
            if (dgvMedico.Columns.Contains("IdEspecialidad")) dgvMedico.Columns["IdEspecialidad"].DisplayIndex = 3;
            if (dgvMedico.Columns.Contains("NumeroColegiado")) dgvMedico.Columns["NumeroColegiado"].DisplayIndex = 4;
            if (dgvMedico.Columns.Contains("RutaDoctos")) dgvMedico.Columns["RutaDoctos"].DisplayIndex = 4;

            ConfigurarBotonesAccion();
        }

        private void CargarDatos()
        {
            try
            {
                var lista = objDoctorNegocio.ObtenerTodos();
                dgvMedico.DataSource = null;
                dgvMedico.DataSource = lista;

                if (dgvMedico.Columns.Count > 0)
                {

                    if (dgvMedico.Columns.Contains("IdDoctor")) dgvMedico.Columns["IdDoctor"].Visible = false;

                    if (dgvMedico.Columns.Contains("Nombre"))
                        dgvMedico.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    if (dgvMedico.Columns.Contains("Apellidos"))
                        dgvMedico.Columns["Apellidos"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    if (dgvMedico.Columns.Contains("NumeroColegiado"))
                        dgvMedico.Columns["NumeroColegiado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    if (dgvMedico.Columns.Contains("Telefono"))
                        dgvMedico.Columns["Telefono"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    if (dgvMedico.Columns.Contains("RutaDoctos"))
                        dgvMedico.Columns["RutaDoctos"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    if (dgvMedico.Columns.Count > 0)
                    {

                        if (dgvMedico.Columns.Contains("IdEspecialidad"))
                            dgvMedico.Columns["IdEspecialidad"].Visible = false;


                        if (dgvMedico.Columns.Contains("NombreEspecialidad"))
                        {
                            dgvMedico.Columns["NombreEspecialidad"].HeaderText = "Especialidad";
                            dgvMedico.Columns["NombreEspecialidad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dgvMedico.Columns["NombreEspecialidad"].DisplayIndex = 3;
                        }

                        ConfigurarBotonesAccion();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ConfigurarBotonesAccion()
        {
            if (dgvMedico.Columns.Contains("EDITAR") && dgvMedico.Columns.Contains("ELIMINAR"))
            {

                int ultimaPosicion = dgvMedico.Columns.Count - 1;


                dgvMedico.Columns["EDITAR"].DisplayIndex = ultimaPosicion - 1;
                dgvMedico.Columns["ELIMINAR"].DisplayIndex = ultimaPosicion;

                dgvMedico.Columns["EDITAR"].Width = 40;
                dgvMedico.Columns["ELIMINAR"].Width = 40;


                dgvMedico.Columns["EDITAR"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvMedico.Columns["ELIMINAR"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
        }

        private void CargarDoctor()
        {

            CL_Doctor objDoctor = new CL_Doctor();
            dgvMedico.DataSource = objDoctor.ObtenerTodos();

            dgvMedico.Columns["IdDoctor"].Visible = false;
            dgvMedico.Columns["Nombre"].HeaderText = "Doctor";
        }
        private void ConfigurarDisenoTabla()
        {

            dgvMedico.BackgroundColor = Color.White;
            dgvMedico.BorderStyle = BorderStyle.None;
            dgvMedico.RowHeadersVisible = false;
            dgvMedico.AllowUserToAddRows = false;
            dgvMedico.AllowUserToResizeColumns = false;
            dgvMedico.AllowUserToResizeRows = false;
            dgvMedico.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMedico.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 86, 145);
            dgvMedico.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMedico.EnableHeadersVisualStyles = false;
            dgvMedico.RowTemplate.Height = 45;
            dgvMedico.DefaultCellStyle.Padding = new Padding(5, 0, 5, 0);

        }

        private void AgregarColumnasAcciones()

        {
            if (!dgvMedico.Columns.Contains("EDITAR"))
            {
                DataGridViewImageColumn colEditar = new DataGridViewImageColumn();
                colEditar.Name = "EDITAR";
                colEditar.HeaderText = "";
                colEditar.Image = IconChar.Edit.ToBitmap(Color.FromArgb(0, 86, 145), 24);
                colEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;
                colEditar.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvMedico.Columns.Add(colEditar);

            }

            if (!dgvMedico.Columns.Contains("ELIMINAR"))
            {
                DataGridViewImageColumn colEliminar = new DataGridViewImageColumn();
                colEliminar.Name = "ELIMINAR";
                colEliminar.HeaderText = "";
                colEliminar.Image = IconChar.TrashAlt.ToBitmap(Color.Crimson, 24);
                colEliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
                colEliminar.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvMedico.Columns.Add(colEliminar);
            }

        }



        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarPacientes(txtBuscar.Text.Trim());

        }

        private void FiltrarPacientes(string filtro)
        {
            var listaCompleta = objDoctorNegocio.ObtenerTodos();


            if (string.IsNullOrWhiteSpace(filtro))
            {
                dgvMedico.DataSource = listaCompleta;
            }
            else
            {
                string filtroLimpio = EliminarTildes(filtro.ToLower());

                var listaFiltrada = listaCompleta.Where(p =>
                    EliminarTildes(p.Nombre.ToLower()).Contains(filtroLimpio) ||
                    EliminarTildes(p.Apellidos.ToLower()).Contains(filtroLimpio) ||
                    // Buscador por correo aqui (futuro)
                    p.Telefono.Contains(filtroLimpio)
                ).ToList();

                dgvMedico.DataSource = listaFiltrada;
            }

            if (dgvMedico.Columns.Count > 0 && dgvMedico.Columns.Contains("EDITAR") && dgvMedico.Columns.Contains("ELIMINAR"))
            {
                int ultimo = dgvMedico.Columns.Count - 1;
                dgvMedico.Columns["EDITAR"].DisplayIndex = ultimo - 1;
                dgvMedico.Columns["ELIMINAR"].DisplayIndex = ultimo;
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


            if (controlHijo is ucMedicoAgregar ucAgregar)
            {
                ucAgregar.RegistroGuardado += (s, args) =>
                {
                    CargarDatos();
                    panel1.Width = 0;
                };
            }
            if (controlHijo is ucEspecialidadAgregar ucEsp)
            {
                ucEsp.RegistroGuardado += (s, args) =>
                {
                    panel1.Width = 0;


                };
            }
        }

        private void bt_agregarmedico_Click(object sender, EventArgs e)
        {
            ucMedicoAgregar ucHijo = new ucMedicoAgregar();
            CargarFormularioEnPanel(ucHijo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucEspecialidadAgregar ucHijo = new ucEspecialidadAgregar();
            CargarFormularioEnPanel(ucHijo);
        }

        private void bt_paciente_Click(object sender, EventArgs e)
        {

            CP_Pacientes nuevaPantalla = new CP_Pacientes();
            nuevaPantalla.Show();


            this.Hide();
        }

        private void dgvMedico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            string nombreColumna = dgvMedico.Columns[e.ColumnIndex].Name;
            int idDoctor = Convert.ToInt32(dgvMedico.Rows[e.RowIndex].Cells["IdDoctor"].Value);


            if (nombreColumna == "ELIMINAR")
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿Estás seguro de eliminar a este doctor? Se borrarán también todos los turnos que tenga asignados en la agenda.",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (respuesta == DialogResult.Yes)
                {
                    try
                    {

                        bool exito = objDoctorNegocio.DelDoctor(idDoctor);

                        if (exito)
                        {
                            MessageBox.Show("Médico y su agenda eliminados correctamente.", "Sistema");
                            CargarDatos();
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Error al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            else if (nombreColumna == "EDITAR")
            {
                ucMedicoAgregar ucHijo = new ucMedicoAgregar();

                string nombre = dgvMedico.Rows[e.RowIndex].Cells["Nombre"].Value?.ToString() ?? "";
                string apellido = dgvMedico.Rows[e.RowIndex].Cells["Apellidos"].Value?.ToString() ?? "";
                string telefono = dgvMedico.Rows[e.RowIndex].Cells["Telefono"].Value?.ToString() ?? "";
                string colegiado = dgvMedico.Rows[e.RowIndex].Cells["NumeroColegiado"].Value?.ToString() ?? "";
                int idEspecialidad = Convert.ToInt32(dgvMedico.Rows[e.RowIndex].Cells["IdEspecialidad"].Value);


                ucHijo.CargarDatosEdicion(idDoctor, nombre, apellido, telefono, colegiado, idEspecialidad);

                CargarFormularioEnPanel(ucHijo);
            }
        }

        private void bt_consultas_Click(object sender, EventArgs e)
        {

        }

        private void panel_nav_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
