namespace CapaPresentacion
{
    partial class ucPacienteAgregar
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            tlp_EdicionPa = new TableLayoutPanel();
            panel_header = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel_edicion = new Panel();
            label11 = new Label();
            lib_archivos = new ListBox();
            label10 = new Label();
            tb_ruta = new TextBox();
            button1 = new Button();
            bt_aggguardar = new Button();
            label9 = new Label();
            tb_agginfoadd = new TextBox();
            cb_aggtipodangre = new ComboBox();
            tb_aggdireccion = new TextBox();
            tb_aggtelefono = new TextBox();
            tb_aggapellido = new TextBox();
            tb_aggnombre = new TextBox();
            dtp_aggfechanac = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            bt_cerrar = new Button();
            tlp_EdicionPa.SuspendLayout();
            panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_edicion.SuspendLayout();
            SuspendLayout();
            // 
            // tlp_EdicionPa
            // 
            tlp_EdicionPa.ColumnCount = 1;
            tlp_EdicionPa.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp_EdicionPa.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlp_EdicionPa.Controls.Add(panel_header, 0, 0);
            tlp_EdicionPa.Controls.Add(panel_edicion, 0, 1);
            tlp_EdicionPa.Location = new Point(0, 0);
            tlp_EdicionPa.Name = "tlp_EdicionPa";
            tlp_EdicionPa.RowCount = 2;
            tlp_EdicionPa.RowStyles.Add(new RowStyle(SizeType.Percent, 15.9649124F));
            tlp_EdicionPa.RowStyles.Add(new RowStyle(SizeType.Percent, 84.03509F));
            tlp_EdicionPa.Size = new Size(400, 725);
            tlp_EdicionPa.TabIndex = 1;
            // 
            // panel_header
            // 
            panel_header.BackColor = Color.FromArgb(36, 37, 60);
            panel_header.Controls.Add(bt_cerrar);
            panel_header.Controls.Add(pictureBox1);
            panel_header.Controls.Add(label1);
            panel_header.Controls.Add(label2);
            panel_header.Dock = DockStyle.Fill;
            panel_header.Location = new Point(3, 3);
            panel_header.Name = "panel_header";
            panel_header.Size = new Size(394, 109);
            panel_header.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ddsa;
            pictureBox1.Location = new Point(28, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(123, 24);
            label1.Name = "label1";
            label1.Size = new Size(65, 19);
            label1.TabIndex = 0;
            label1.Text = "Agregar";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(94, 32);
            label2.Name = "label2";
            label2.Size = new Size(183, 54);
            label2.TabIndex = 1;
            label2.Text = "Paciente";
            // 
            // panel_edicion
            // 
            panel_edicion.BackColor = Color.FromArgb(248, 249, 255);
            panel_edicion.Controls.Add(label11);
            panel_edicion.Controls.Add(lib_archivos);
            panel_edicion.Controls.Add(label10);
            panel_edicion.Controls.Add(tb_ruta);
            panel_edicion.Controls.Add(button1);
            panel_edicion.Controls.Add(bt_aggguardar);
            panel_edicion.Controls.Add(label9);
            panel_edicion.Controls.Add(tb_agginfoadd);
            panel_edicion.Controls.Add(cb_aggtipodangre);
            panel_edicion.Controls.Add(tb_aggdireccion);
            panel_edicion.Controls.Add(tb_aggtelefono);
            panel_edicion.Controls.Add(tb_aggapellido);
            panel_edicion.Controls.Add(tb_aggnombre);
            panel_edicion.Controls.Add(dtp_aggfechanac);
            panel_edicion.Controls.Add(label8);
            panel_edicion.Controls.Add(label7);
            panel_edicion.Controls.Add(label6);
            panel_edicion.Controls.Add(label5);
            panel_edicion.Controls.Add(label4);
            panel_edicion.Controls.Add(label3);
            panel_edicion.Dock = DockStyle.Fill;
            panel_edicion.Location = new Point(3, 118);
            panel_edicion.Name = "panel_edicion";
            panel_edicion.Size = new Size(394, 604);
            panel_edicion.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(36, 37, 60);
            label11.Location = new Point(136, 363);
            label11.Name = "label11";
            label11.Size = new Size(126, 19);
            label11.TabIndex = 33;
            label11.Text = "Agregar Historial";
            // 
            // lib_archivos
            // 
            lib_archivos.FormattingEnabled = true;
            lib_archivos.ItemHeight = 15;
            lib_archivos.Location = new Point(24, 437);
            lib_archivos.Margin = new Padding(3, 2, 3, 2);
            lib_archivos.Name = "lib_archivos";
            lib_archivos.Size = new Size(348, 79);
            lib_archivos.TabIndex = 32;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(36, 37, 60);
            label10.Location = new Point(28, 407);
            label10.Name = "label10";
            label10.Size = new Size(39, 19);
            label10.TabIndex = 31;
            label10.Text = "Ruta";
            // 
            // tb_ruta
            // 
            tb_ruta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_ruta.BackColor = Color.White;
            tb_ruta.BorderStyle = BorderStyle.FixedSingle;
            tb_ruta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_ruta.Location = new Point(84, 405);
            tb_ruta.Name = "tb_ruta";
            tb_ruta.Size = new Size(233, 22);
            tb_ruta.TabIndex = 30;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(37, 38, 60);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.subirog;
            button1.Location = new Point(336, 402);
            button1.Name = "button1";
            button1.Size = new Size(36, 27);
            button1.TabIndex = 29;
            button1.UseVisualStyleBackColor = false;
            // 
            // bt_aggguardar
            // 
            bt_aggguardar.BackColor = Color.FromArgb(37, 38, 60);
            bt_aggguardar.FlatAppearance.BorderSize = 0;
            bt_aggguardar.FlatStyle = FlatStyle.Flat;
            bt_aggguardar.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_aggguardar.ForeColor = Color.White;
            bt_aggguardar.ImageAlign = ContentAlignment.MiddleLeft;
            bt_aggguardar.Location = new Point(115, 535);
            bt_aggguardar.Name = "bt_aggguardar";
            bt_aggguardar.Size = new Size(162, 44);
            bt_aggguardar.TabIndex = 24;
            bt_aggguardar.Text = "Guardar";
            bt_aggguardar.UseVisualStyleBackColor = false;
            bt_aggguardar.Click += bt_aggguardar_Click_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(36, 37, 60);
            label9.Location = new Point(124, 248);
            label9.Name = "label9";
            label9.Size = new Size(153, 19);
            label9.TabIndex = 23;
            label9.Text = "Información Adcional";
            // 
            // tb_agginfoadd
            // 
            tb_agginfoadd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_agginfoadd.BackColor = Color.White;
            tb_agginfoadd.BorderStyle = BorderStyle.FixedSingle;
            tb_agginfoadd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_agginfoadd.Location = new Point(23, 279);
            tb_agginfoadd.Multiline = true;
            tb_agginfoadd.Name = "tb_agginfoadd";
            tb_agginfoadd.Size = new Size(349, 62);
            tb_agginfoadd.TabIndex = 22;
            // 
            // cb_aggtipodangre
            // 
            cb_aggtipodangre.BackColor = Color.White;
            cb_aggtipodangre.FormattingEnabled = true;
            cb_aggtipodangre.Items.AddRange(new object[] { "A+´", "A-", "O+", "O-", "B+", "B-" });
            cb_aggtipodangre.Location = new Point(213, 212);
            cb_aggtipodangre.Name = "cb_aggtipodangre";
            cb_aggtipodangre.Size = new Size(159, 23);
            cb_aggtipodangre.TabIndex = 21;
            // 
            // tb_aggdireccion
            // 
            tb_aggdireccion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_aggdireccion.BackColor = Color.White;
            tb_aggdireccion.BorderStyle = BorderStyle.FixedSingle;
            tb_aggdireccion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_aggdireccion.Location = new Point(24, 203);
            tb_aggdireccion.Multiline = true;
            tb_aggdireccion.Name = "tb_aggdireccion";
            tb_aggdireccion.Size = new Size(156, 40);
            tb_aggdireccion.TabIndex = 20;
            // 
            // tb_aggtelefono
            // 
            tb_aggtelefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_aggtelefono.BackColor = Color.White;
            tb_aggtelefono.BorderStyle = BorderStyle.FixedSingle;
            tb_aggtelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_aggtelefono.Location = new Point(24, 134);
            tb_aggtelefono.Name = "tb_aggtelefono";
            tb_aggtelefono.Size = new Size(156, 22);
            tb_aggtelefono.TabIndex = 19;
            // 
            // tb_aggapellido
            // 
            tb_aggapellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_aggapellido.BackColor = Color.White;
            tb_aggapellido.BorderStyle = BorderStyle.FixedSingle;
            tb_aggapellido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_aggapellido.Location = new Point(213, 57);
            tb_aggapellido.Name = "tb_aggapellido";
            tb_aggapellido.Size = new Size(159, 22);
            tb_aggapellido.TabIndex = 18;
            // 
            // tb_aggnombre
            // 
            tb_aggnombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_aggnombre.BackColor = Color.White;
            tb_aggnombre.BorderStyle = BorderStyle.FixedSingle;
            tb_aggnombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_aggnombre.Location = new Point(24, 57);
            tb_aggnombre.Name = "tb_aggnombre";
            tb_aggnombre.Size = new Size(156, 22);
            tb_aggnombre.TabIndex = 17;
            // 
            // dtp_aggfechanac
            // 
            dtp_aggfechanac.CalendarMonthBackground = Color.FromArgb(217, 220, 255);
            dtp_aggfechanac.Format = DateTimePickerFormat.Short;
            dtp_aggfechanac.Location = new Point(213, 133);
            dtp_aggfechanac.Name = "dtp_aggfechanac";
            dtp_aggfechanac.Size = new Size(159, 23);
            dtp_aggfechanac.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(36, 37, 60);
            label8.Location = new Point(24, 174);
            label8.Name = "label8";
            label8.Size = new Size(72, 19);
            label8.TabIndex = 5;
            label8.Text = "Dirección";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(36, 37, 60);
            label7.Location = new Point(213, 174);
            label7.Name = "label7";
            label7.Size = new Size(111, 19);
            label7.TabIndex = 4;
            label7.Text = "Tipo de Sangre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(36, 37, 60);
            label6.Location = new Point(24, 95);
            label6.Name = "label6";
            label6.Size = new Size(67, 19);
            label6.TabIndex = 3;
            label6.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(36, 37, 60);
            label5.Location = new Point(213, 95);
            label5.Name = "label5";
            label5.Size = new Size(149, 19);
            label5.TabIndex = 2;
            label5.Text = "Fecha de Nacimiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(36, 37, 60);
            label4.Location = new Point(213, 22);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 1;
            label4.Text = "Apellidos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(36, 37, 60);
            label3.Location = new Point(23, 22);
            label3.Name = "label3";
            label3.Size = new Size(81, 19);
            label3.TabIndex = 0;
            label3.Text = "Nombre(s)";
            // 
            // bt_cerrar
            // 
            bt_cerrar.BackColor = Color.FromArgb(52, 57, 91);
            bt_cerrar.FlatAppearance.BorderSize = 0;
            bt_cerrar.FlatStyle = FlatStyle.Flat;
            bt_cerrar.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_cerrar.ForeColor = Color.White;
            bt_cerrar.ImageAlign = ContentAlignment.MiddleLeft;
            bt_cerrar.Location = new Point(344, 7);
            bt_cerrar.Name = "bt_cerrar";
            bt_cerrar.Size = new Size(43, 31);
            bt_cerrar.TabIndex = 27;
            bt_cerrar.Text = "X";
            bt_cerrar.UseVisualStyleBackColor = false;
            // 
            // ucPacienteAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlp_EdicionPa);
            Name = "ucPacienteAgregar";
            Size = new Size(400, 725);
            tlp_EdicionPa.ResumeLayout(false);
            panel_header.ResumeLayout(false);
            panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_edicion.ResumeLayout(false);
            panel_edicion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlp_EdicionPa;
        private Panel panel_header;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Panel panel_edicion;
        private Button bt_aggguardar;
        private Label label9;
        private TextBox tb_agginfoadd;
        private ComboBox cb_aggtipodangre;
        private TextBox tb_aggdireccion;
        private TextBox tb_aggtelefono;
        private TextBox tb_aggapellido;
        private TextBox tb_aggnombre;
        private DateTimePicker dtp_aggfechanac;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ListBox lib_archivos;
        private Label label10;
        private TextBox tb_ruta;
        private Button button1;
        private Label label11;
        private Button bt_cerrar;
    }
}
