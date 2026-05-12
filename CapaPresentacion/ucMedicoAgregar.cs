using CapaDatos;
using CapaEntities;
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
    public partial class ucMedicoAgregar : UserControl
    {
        public event EventHandler RegistroGuardado;
        private int idDoctorActual = 0;
        public ucMedicoAgregar()
        {
            InitializeComponent();
            LlenarComboEspecialidades();
        }

        private void panel_edicion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LimpiarCampos()
        {
            idDoctorActual = 0;
            tb_edinombre.Clear();
            tb_ediapellido.Clear();
            tb_editelefono.Clear();
            tb_edidireccion.Clear();
            cb_editipodangre.SelectedIndex = -1;

        }


        private void bt_ediguardar_Click(object sender, EventArgs e)
        {

            //El codigo comentado es para cuanto tengamos pantallas distintas de agregar y editar 
            //por el momento usamos la misma de agregar
            /*
            if (string.IsNullOrWhiteSpace(tb_edinombre.Text) || string.IsNullOrWhiteSpace(tb_ediapellido.Text))
            {
                MessageBox.Show("Por favor, completa el nombre y el apellido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validación del ComboBox
            if (cb_editipodangre.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecciona una especialidad válida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                CE_Doctor nuevoDoctor = new CE_Doctor
                {
                    IdDoctor = 0,
                    Nombre = tb_edinombre.Text.Trim(),
                    Apellidos = tb_ediapellido.Text.Trim(),
                    Telefono = tb_editelefono.Text.Trim(),
                    NumeroColegiado = tb_edidireccion.Text.Trim(),
                    // Obtenemos el ID numérico del combo
                    IdEspecialidad = Convert.ToInt32(cb_editipodangre.SelectedValue)
                };

                CL_Doctor objNegocio = new CL_Doctor();
                bool exito = objNegocio.AddDoctor(nuevoDoctor);

                if (exito)
                {
                    MessageBox.Show("Médico registrado con éxito.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    RegistroGuardado?.Invoke(this, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */


            if (string.IsNullOrWhiteSpace(tb_edinombre.Text) || string.IsNullOrWhiteSpace(tb_ediapellido.Text))
            {
                MessageBox.Show("Por favor, completa los campos obligatorios.");
                return;
            }

            try
            {

                CE_Doctor doctor = new CE_Doctor
                {
                    IdDoctor = idDoctorActual,
                    Nombre = tb_edinombre.Text.Trim(),
                    Apellidos = tb_ediapellido.Text.Trim(),
                    Telefono = tb_editelefono.Text.Trim(),
                    NumeroColegiado = tb_edidireccion.Text.Trim(),
                    IdEspecialidad = Convert.ToInt32(cb_editipodangre.SelectedValue)
                };

                CL_Doctor objNegocio = new CL_Doctor();
                bool exito = false;


                if (idDoctorActual == 0)
                {

                    exito = objNegocio.AddDoctor(doctor);
                }
                else
                {

                    exito = objNegocio.UpdDoctor(doctor);
                }

                if (exito)
                {
                    MessageBox.Show(idDoctorActual == 0 ? "Registrado con éxito" : "Actualizado con éxito");


                    idDoctorActual = 0;

                    LimpiarCampos();
                    RegistroGuardado?.Invoke(this, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void CargarDatosEdicion(int id, string nombre, string apellido, string telefono, string colegiado, int idEspecialidad)
        {
            idDoctorActual = id;
            tb_edinombre.Text = nombre;
            tb_ediapellido.Text = apellido;
            tb_editelefono.Text = telefono;
            tb_edidireccion.Text = colegiado;
            cb_editipodangre.SelectedValue = idEspecialidad;
        }

        private void LlenarComboEspecialidades()
        {
            try
            {
                CL_Especialidad objLogica = new CL_Especialidad();
                var lista = objLogica.ObtenerTodas();

                cb_editipodangre.DataSource = lista;
                cb_editipodangre.DisplayMember = "Nombre";
                cb_editipodangre.ValueMember = "IdEspecialidad";

                cb_editipodangre.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar especialidades: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rutaOrigen = "";
            
            OpenFileDialog abrir = new OpenFileDialog();

            abrir.Title = "PDF|*.pdf|WORD|*.docx|Imagenes|*.jpg; *.png";
            if(abrir.ShowDialog() == DialogResult.OK)
            {
                rutaOrigen= abrir.FileName;
                tb_ruta.Text = rutaOrigen;
                
            } try
            {
                string rutaDestino = @"C:\Users\ledez\Downloads\control escolar";
               if(!Directory.Exists(rutaDestino))
                {
                    Directory.CreateDirectory(rutaDestino);
                }
                string nombreArchivo = Path.GetFileName(rutaOrigen);
                String nombreDestino = Path.Combine(rutaDestino,nombreArchivo);
                File.Copy(rutaOrigen, nombreDestino, true);
                CargarLB();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
             
        }
        void CargarLB()
        {

        }
    }
}
