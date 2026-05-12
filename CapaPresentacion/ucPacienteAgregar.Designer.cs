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
            tlp_EdicionPa.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tlp_EdicionPa.Controls.Add(panel_header, 0, 0);
            tlp_EdicionPa.Controls.Add(panel_edicion, 0, 1);
            tlp_EdicionPa.Location = new Point(0, 0);
            tlp_EdicionPa.Margin = new Padding(3, 4, 3, 4);
            tlp_EdicionPa.Name = "tlp_EdicionPa";
            tlp_EdicionPa.RowCount = 2;
            tlp_EdicionPa.RowStyles.Add(new RowStyle(SizeType.Percent, 15.9649124F));
            tlp_EdicionPa.RowStyles.Add(new RowStyle(SizeType.Percent, 84.03509F));
            tlp_EdicionPa.Size = new Size(457, 760);
            tlp_EdicionPa.TabIndex = 1;
            // 
            // panel_header
            // 
            panel_header.BackColor = Color.FromArgb(36, 37, 60);
            panel_header.Controls.Add(pictureBox1);
            panel_header.Controls.Add(label1);
            panel_header.Controls.Add(label2);
            panel_header.Dock = DockStyle.Fill;
            panel_header.Location = new Point(3, 4);
            panel_header.Margin = new Padding(3, 4, 3, 4);
            panel_header.Name = "panel_header";
            panel_header.Size = new Size(451, 113);
            panel_header.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ddsa;
            pictureBox1.Location = new Point(32, 15);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(123, 20);
            label1.Name = "label1";
            label1.Size = new Size(76, 23);
            label1.TabIndex = 0;
            label1.Text = "Agregar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(101, 31);
            label2.Name = "label2";
            label2.Size = new Size(183, 54);
            label2.TabIndex = 1;
            label2.Text = "Paciente";
            // 
            // panel_edicion
            // 
            panel_edicion.BackColor = Color.FromArgb(248, 249, 255);
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
            panel_edicion.Location = new Point(3, 125);
            panel_edicion.Margin = new Padding(3, 4, 3, 4);
            panel_edicion.Name = "panel_edicion";
            panel_edicion.Size = new Size(451, 631);
            panel_edicion.TabIndex = 1;
            // 
            // bt_aggguardar
            // 
            bt_aggguardar.BackColor = Color.FromArgb(37, 38, 60);
            bt_aggguardar.FlatAppearance.BorderSize = 0;
            bt_aggguardar.FlatStyle = FlatStyle.Flat;
            bt_aggguardar.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_aggguardar.ForeColor = Color.White;
            bt_aggguardar.ImageAlign = ContentAlignment.MiddleLeft;
            bt_aggguardar.Location = new Point(131, 544);
            bt_aggguardar.Margin = new Padding(3, 4, 3, 4);
            bt_aggguardar.Name = "bt_aggguardar";
            bt_aggguardar.Size = new Size(185, 59);
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
            label9.Location = new Point(142, 373);
            label9.Name = "label9";
            label9.Size = new Size(182, 23);
            label9.TabIndex = 23;
            label9.Text = "Información Adcional";
            // 
            // tb_agginfoadd
            // 
            tb_agginfoadd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_agginfoadd.BackColor = Color.FromArgb(217, 220, 255);
            tb_agginfoadd.BorderStyle = BorderStyle.None;
            tb_agginfoadd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_agginfoadd.Location = new Point(26, 415);
            tb_agginfoadd.Margin = new Padding(3, 4, 3, 4);
            tb_agginfoadd.Multiline = true;
            tb_agginfoadd.Name = "tb_agginfoadd";
            tb_agginfoadd.Size = new Size(400, 108);
            tb_agginfoadd.TabIndex = 22;
            // 
            // cb_aggtipodangre
            // 
            cb_aggtipodangre.BackColor = Color.FromArgb(217, 220, 255);
            cb_aggtipodangre.FlatStyle = FlatStyle.Flat;
            cb_aggtipodangre.FormattingEnabled = true;
            cb_aggtipodangre.Items.AddRange(new object[] { "A+´", "A-", "O+", "O-", "B+", "B-" });
            cb_aggtipodangre.Location = new Point(243, 315);
            cb_aggtipodangre.Margin = new Padding(3, 4, 3, 4);
            cb_aggtipodangre.Name = "cb_aggtipodangre";
            cb_aggtipodangre.Size = new Size(181, 28);
            cb_aggtipodangre.TabIndex = 21;
            // 
            // tb_aggdireccion
            // 
            tb_aggdireccion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_aggdireccion.BackColor = Color.FromArgb(217, 220, 255);
            tb_aggdireccion.BorderStyle = BorderStyle.None;
            tb_aggdireccion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_aggdireccion.Location = new Point(27, 316);
            tb_aggdireccion.Margin = new Padding(3, 4, 3, 4);
            tb_aggdireccion.Name = "tb_aggdireccion";
            tb_aggdireccion.Size = new Size(179, 27);
            tb_aggdireccion.TabIndex = 20;
            // 
            // tb_aggtelefono
            // 
            tb_aggtelefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_aggtelefono.BackColor = Color.FromArgb(217, 220, 255);
            tb_aggtelefono.BorderStyle = BorderStyle.None;
            tb_aggtelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_aggtelefono.Location = new Point(27, 195);
            tb_aggtelefono.Margin = new Padding(3, 4, 3, 4);
            tb_aggtelefono.Name = "tb_aggtelefono";
            tb_aggtelefono.Size = new Size(179, 27);
            tb_aggtelefono.TabIndex = 19;
            // 
            // tb_aggapellido
            // 
            tb_aggapellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_aggapellido.BackColor = Color.FromArgb(217, 220, 255);
            tb_aggapellido.BorderStyle = BorderStyle.None;
            tb_aggapellido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_aggapellido.Location = new Point(243, 76);
            tb_aggapellido.Margin = new Padding(3, 4, 3, 4);
            tb_aggapellido.Name = "tb_aggapellido";
            tb_aggapellido.Size = new Size(183, 27);
            tb_aggapellido.TabIndex = 18;
            // 
            // tb_aggnombre
            // 
            tb_aggnombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_aggnombre.BackColor = Color.FromArgb(217, 220, 255);
            tb_aggnombre.BorderStyle = BorderStyle.None;
            tb_aggnombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_aggnombre.Location = new Point(27, 76);
            tb_aggnombre.Margin = new Padding(3, 4, 3, 4);
            tb_aggnombre.Name = "tb_aggnombre";
            tb_aggnombre.Size = new Size(179, 27);
            tb_aggnombre.TabIndex = 17;
            // 
            // dtp_aggfechanac
            // 
            dtp_aggfechanac.CalendarMonthBackground = Color.FromArgb(217, 220, 255);
            dtp_aggfechanac.Format = DateTimePickerFormat.Short;
            dtp_aggfechanac.Location = new Point(243, 193);
            dtp_aggfechanac.Margin = new Padding(3, 4, 3, 4);
            dtp_aggfechanac.Name = "dtp_aggfechanac";
            dtp_aggfechanac.Size = new Size(181, 27);
            dtp_aggfechanac.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(36, 37, 60);
            label8.Location = new Point(27, 264);
            label8.Name = "label8";
            label8.Size = new Size(85, 23);
            label8.TabIndex = 5;
            label8.Text = "Dirección";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(36, 37, 60);
            label7.Location = new Point(243, 264);
            label7.Name = "label7";
            label7.Size = new Size(132, 23);
            label7.TabIndex = 4;
            label7.Text = "Tipo de Sangre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(36, 37, 60);
            label6.Location = new Point(27, 143);
            label6.Name = "label6";
            label6.Size = new Size(78, 23);
            label6.TabIndex = 3;
            label6.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(36, 37, 60);
            label5.Location = new Point(243, 143);
            label5.Name = "label5";
            label5.Size = new Size(177, 23);
            label5.TabIndex = 2;
            label5.Text = "Fecha de Nacimiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(36, 37, 60);
            label4.Location = new Point(243, 29);
            label4.Name = "label4";
            label4.Size = new Size(85, 23);
            label4.TabIndex = 1;
            label4.Text = "Apellidos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(36, 37, 60);
            label3.Location = new Point(26, 29);
            label3.Name = "label3";
            label3.Size = new Size(95, 23);
            label3.TabIndex = 0;
            label3.Text = "Nombre(s)";
            // 
            // ucPacienteAgregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlp_EdicionPa);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ucPacienteAgregar";
            Size = new Size(457, 760);
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
    }
}
