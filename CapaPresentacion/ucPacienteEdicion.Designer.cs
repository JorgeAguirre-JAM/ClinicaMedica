namespace CapaPresentacion
{
    partial class ucPacienteEdicion
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
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dtp_edifechanac = new DateTimePicker();
            tb_edinombre = new TextBox();
            tb_ediapellido = new TextBox();
            tb_editelefono = new TextBox();
            tb_edidireccion = new TextBox();
            cb_editipodangre = new ComboBox();
            tb_ediinfoadd = new TextBox();
            label9 = new Label();
            panel_edicion = new Panel();
            bt_ediguardar = new Button();
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
            tlp_EdicionPa.Size = new Size(400, 570);
            tlp_EdicionPa.TabIndex = 0;
            // 
            // panel_header
            // 
            panel_header.BackColor = Color.FromArgb(36, 37, 60);
            panel_header.Controls.Add(pictureBox1);
            panel_header.Controls.Add(label1);
            panel_header.Controls.Add(label2);
            panel_header.Dock = DockStyle.Fill;
            panel_header.Location = new Point(3, 3);
            panel_header.Name = "panel_header";
            panel_header.Size = new Size(394, 85);
            panel_header.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(115, 15);
            label1.Name = "label1";
            label1.Size = new Size(48, 19);
            label1.TabIndex = 0;
            label1.Text = "Editar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(88, 23);
            label2.Name = "label2";
            label2.Size = new Size(145, 45);
            label2.TabIndex = 1;
            label2.Text = "Paciente";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dsfsdf;
            pictureBox1.Location = new Point(28, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(36, 37, 60);
            label5.Location = new Point(213, 107);
            label5.Name = "label5";
            label5.Size = new Size(149, 19);
            label5.TabIndex = 2;
            label5.Text = "Fecha de Nacimiento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(36, 37, 60);
            label6.Location = new Point(24, 107);
            label6.Name = "label6";
            label6.Size = new Size(67, 19);
            label6.TabIndex = 3;
            label6.Text = "Telefono";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(36, 37, 60);
            label7.Location = new Point(213, 198);
            label7.Name = "label7";
            label7.Size = new Size(111, 19);
            label7.TabIndex = 4;
            label7.Text = "Tipo de Sangre";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(36, 37, 60);
            label8.Location = new Point(24, 198);
            label8.Name = "label8";
            label8.Size = new Size(72, 19);
            label8.TabIndex = 5;
            label8.Text = "Dirección";
            // 
            // dtp_edifechanac
            // 
            dtp_edifechanac.CalendarMonthBackground = Color.FromArgb(217, 220, 255);
            dtp_edifechanac.Format = DateTimePickerFormat.Short;
            dtp_edifechanac.Location = new Point(213, 145);
            dtp_edifechanac.Name = "dtp_edifechanac";
            dtp_edifechanac.Size = new Size(159, 23);
            dtp_edifechanac.TabIndex = 9;
            // 
            // tb_edinombre
            // 
            tb_edinombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_edinombre.BackColor = Color.FromArgb(217, 220, 255);
            tb_edinombre.BorderStyle = BorderStyle.None;
            tb_edinombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_edinombre.Location = new Point(24, 57);
            tb_edinombre.Name = "tb_edinombre";
            tb_edinombre.Size = new Size(156, 22);
            tb_edinombre.TabIndex = 17;
            // 
            // tb_ediapellido
            // 
            tb_ediapellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_ediapellido.BackColor = Color.FromArgb(217, 220, 255);
            tb_ediapellido.BorderStyle = BorderStyle.None;
            tb_ediapellido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_ediapellido.Location = new Point(213, 57);
            tb_ediapellido.Name = "tb_ediapellido";
            tb_ediapellido.Size = new Size(156, 22);
            tb_ediapellido.TabIndex = 18;
            // 
            // tb_editelefono
            // 
            tb_editelefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_editelefono.BackColor = Color.FromArgb(217, 220, 255);
            tb_editelefono.BorderStyle = BorderStyle.None;
            tb_editelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_editelefono.Location = new Point(24, 146);
            tb_editelefono.Name = "tb_editelefono";
            tb_editelefono.Size = new Size(156, 22);
            tb_editelefono.TabIndex = 19;
            // 
            // tb_edidireccion
            // 
            tb_edidireccion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_edidireccion.BackColor = Color.FromArgb(217, 220, 255);
            tb_edidireccion.BorderStyle = BorderStyle.None;
            tb_edidireccion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_edidireccion.Location = new Point(24, 237);
            tb_edidireccion.Name = "tb_edidireccion";
            tb_edidireccion.Size = new Size(156, 22);
            tb_edidireccion.TabIndex = 20;
            // 
            // cb_editipodangre
            // 
            cb_editipodangre.BackColor = Color.FromArgb(217, 220, 255);
            cb_editipodangre.FlatStyle = FlatStyle.Flat;
            cb_editipodangre.FormattingEnabled = true;
            cb_editipodangre.Items.AddRange(new object[] { "A+´", "A-", "O+", "O-", "B+", "B-" });
            cb_editipodangre.Location = new Point(213, 236);
            cb_editipodangre.Name = "cb_editipodangre";
            cb_editipodangre.Size = new Size(159, 23);
            cb_editipodangre.TabIndex = 21;
            // 
            // tb_ediinfoadd
            // 
            tb_ediinfoadd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_ediinfoadd.BackColor = Color.FromArgb(217, 220, 255);
            tb_ediinfoadd.BorderStyle = BorderStyle.None;
            tb_ediinfoadd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_ediinfoadd.Location = new Point(23, 311);
            tb_ediinfoadd.Multiline = true;
            tb_ediinfoadd.Name = "tb_ediinfoadd";
            tb_ediinfoadd.Size = new Size(349, 81);
            tb_ediinfoadd.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(36, 37, 60);
            label9.Location = new Point(124, 280);
            label9.Name = "label9";
            label9.Size = new Size(153, 19);
            label9.TabIndex = 23;
            label9.Text = "Información Adcional";
            // 
            // panel_edicion
            // 
            panel_edicion.Controls.Add(bt_ediguardar);
            panel_edicion.Controls.Add(label9);
            panel_edicion.Controls.Add(tb_ediinfoadd);
            panel_edicion.Controls.Add(cb_editipodangre);
            panel_edicion.Controls.Add(tb_edidireccion);
            panel_edicion.Controls.Add(tb_editelefono);
            panel_edicion.Controls.Add(tb_ediapellido);
            panel_edicion.Controls.Add(tb_edinombre);
            panel_edicion.Controls.Add(dtp_edifechanac);
            panel_edicion.Controls.Add(label8);
            panel_edicion.Controls.Add(label7);
            panel_edicion.Controls.Add(label6);
            panel_edicion.Controls.Add(label5);
            panel_edicion.Controls.Add(label4);
            panel_edicion.Controls.Add(label3);
            panel_edicion.Dock = DockStyle.Fill;
            panel_edicion.Location = new Point(3, 94);
            panel_edicion.Name = "panel_edicion";
            panel_edicion.Size = new Size(394, 473);
            panel_edicion.TabIndex = 1;
            // 
            // bt_ediguardar
            // 
            bt_ediguardar.BackColor = Color.FromArgb(37, 38, 60);
            bt_ediguardar.FlatAppearance.BorderSize = 0;
            bt_ediguardar.FlatStyle = FlatStyle.Flat;
            bt_ediguardar.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_ediguardar.ForeColor = Color.White;
            bt_ediguardar.ImageAlign = ContentAlignment.MiddleLeft;
            bt_ediguardar.Location = new Point(115, 408);
            bt_ediguardar.Name = "bt_ediguardar";
            bt_ediguardar.Size = new Size(162, 44);
            bt_ediguardar.TabIndex = 24;
            bt_ediguardar.Text = "Guardar";
            bt_ediguardar.UseVisualStyleBackColor = false;
            // 
            // ucPacienteEdicion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(248, 249, 255);
            Controls.Add(tlp_EdicionPa);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ucPacienteEdicion";
            Size = new Size(400, 570);
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
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel_edicion;
        private Button bt_ediguardar;
        private Label label9;
        private TextBox tb_ediinfoadd;
        private ComboBox cb_editipodangre;
        private TextBox tb_edidireccion;
        private TextBox tb_editelefono;
        private TextBox tb_ediapellido;
        private TextBox tb_edinombre;
        private DateTimePicker dtp_edifechanac;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}
