namespace CapaPresentacion
{
    partial class CP_Pacientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tlp_General = new TableLayoutPanel();
            panel_logo = new Panel();
            pictureBox1 = new PictureBox();
            panel_nav = new Panel();
            bt_config = new Button();
            bt_usuario = new Button();
            panel5 = new Panel();
            button2 = new Button();
            panel4 = new Panel();
            bt_paciente = new Button();
            panel_header = new Panel();
            tlp_busqueda = new TableLayoutPanel();
            dgvPacientes = new DataGridView();
            panel1 = new Panel();
            tlp_busquedanav = new TableLayoutPanel();
            panel_boton = new Panel();
            button3 = new Button();
            panel_buscador = new Panel();
            pictureBox2 = new PictureBox();
            txtBuscar = new TextBox();
            tlp_General.SuspendLayout();
            panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_nav.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            tlp_busqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            tlp_busquedanav.SuspendLayout();
            panel_boton.SuspendLayout();
            panel_buscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tlp_General
            // 
            tlp_General.ColumnCount = 2;
            tlp_General.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.6891613F));
            tlp_General.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.3108444F));
            tlp_General.Controls.Add(panel_logo, 0, 0);
            tlp_General.Controls.Add(panel_nav, 0, 1);
            tlp_General.Controls.Add(panel_header, 1, 0);
            tlp_General.Controls.Add(tlp_busqueda, 1, 1);
            tlp_General.Dock = DockStyle.Fill;
            tlp_General.Location = new Point(0, 0);
            tlp_General.Margin = new Padding(3, 4, 3, 4);
            tlp_General.Name = "tlp_General";
            tlp_General.RowCount = 2;
            tlp_General.RowStyles.Add(new RowStyle(SizeType.Percent, 16.22807F));
            tlp_General.RowStyles.Add(new RowStyle(SizeType.Percent, 83.77193F));
            tlp_General.Size = new Size(1445, 908);
            tlp_General.TabIndex = 0;
            tlp_General.Paint += tableLayoutPanel1_Paint;
            // 
            // panel_logo
            // 
            panel_logo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_logo.BackColor = Color.FromArgb(36, 37, 60);
            panel_logo.Controls.Add(pictureBox1);
            panel_logo.Location = new Point(3, 4);
            panel_logo.Margin = new Padding(3, 4, 3, 4);
            panel_logo.Name = "panel_logo";
            panel_logo.Size = new Size(249, 139);
            panel_logo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.SCCM_lineal_2;
            pictureBox1.Location = new Point(23, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel_nav
            // 
            panel_nav.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_nav.BackColor = Color.FromArgb(36, 37, 60);
            panel_nav.Controls.Add(bt_config);
            panel_nav.Controls.Add(bt_usuario);
            panel_nav.Controls.Add(panel5);
            panel_nav.Controls.Add(panel4);
            panel_nav.Location = new Point(3, 151);
            panel_nav.Margin = new Padding(3, 4, 3, 4);
            panel_nav.Name = "panel_nav";
            panel_nav.Size = new Size(249, 753);
            panel_nav.TabIndex = 1;
            panel_nav.Paint += panel1_Paint;
            // 
            // bt_config
            // 
            bt_config.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bt_config.FlatAppearance.BorderSize = 0;
            bt_config.FlatStyle = FlatStyle.Flat;
            bt_config.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_config.ForeColor = Color.White;
            bt_config.Image = Properties.Resources.config;
            bt_config.Location = new Point(19, 676);
            bt_config.Margin = new Padding(3, 4, 3, 4);
            bt_config.Name = "bt_config";
            bt_config.Size = new Size(44, 53);
            bt_config.TabIndex = 4;
            bt_config.UseVisualStyleBackColor = true;
            // 
            // bt_usuario
            // 
            bt_usuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bt_usuario.FlatAppearance.BorderSize = 0;
            bt_usuario.FlatStyle = FlatStyle.Flat;
            bt_usuario.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_usuario.ForeColor = Color.White;
            bt_usuario.Image = Properties.Resources.paciente;
            bt_usuario.Location = new Point(179, 676);
            bt_usuario.Margin = new Padding(3, 4, 3, 4);
            bt_usuario.Name = "bt_usuario";
            bt_usuario.Size = new Size(44, 53);
            bt_usuario.TabIndex = 3;
            bt_usuario.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(button2);
            panel5.Location = new Point(23, 181);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(203, 84);
            panel5.TabIndex = 1;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.dcotor_icon2;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 4);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Padding = new Padding(29, 0, 0, 0);
            button2.Size = new Size(197, 76);
            button2.TabIndex = 0;
            button2.Text = "    Medico";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(bt_paciente);
            panel4.Location = new Point(23, 75);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(203, 84);
            panel4.TabIndex = 0;
            // 
            // bt_paciente
            // 
            bt_paciente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bt_paciente.FlatAppearance.BorderSize = 0;
            bt_paciente.FlatStyle = FlatStyle.Flat;
            bt_paciente.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_paciente.ForeColor = Color.White;
            bt_paciente.Image = Properties.Resources.paciente;
            bt_paciente.ImageAlign = ContentAlignment.MiddleLeft;
            bt_paciente.Location = new Point(3, 4);
            bt_paciente.Margin = new Padding(3, 4, 3, 4);
            bt_paciente.Name = "bt_paciente";
            bt_paciente.Padding = new Padding(29, 0, 0, 0);
            bt_paciente.Size = new Size(197, 76);
            bt_paciente.TabIndex = 0;
            bt_paciente.Text = "     Paciente";
            bt_paciente.UseVisualStyleBackColor = true;
            bt_paciente.Click += bt_paciente_Click;
            // 
            // panel_header
            // 
            panel_header.Dock = DockStyle.Fill;
            panel_header.Location = new Point(258, 4);
            panel_header.Margin = new Padding(3, 4, 3, 4);
            panel_header.Name = "panel_header";
            panel_header.Size = new Size(1184, 139);
            panel_header.TabIndex = 4;
            // 
            // tlp_busqueda
            // 
            tlp_busqueda.ColumnCount = 2;
            tlp_busqueda.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp_busqueda.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 13F));
            tlp_busqueda.Controls.Add(dgvPacientes, 0, 1);
            tlp_busqueda.Controls.Add(tlp_busquedanav, 0, 0);
            tlp_busqueda.Dock = DockStyle.Fill;
            tlp_busqueda.Location = new Point(258, 151);
            tlp_busqueda.Margin = new Padding(3, 4, 3, 4);
            tlp_busqueda.Name = "tlp_busqueda";
            tlp_busqueda.RowCount = 2;
            tlp_busqueda.RowStyles.Add(new RowStyle(SizeType.Percent, 12.8295259F));
            tlp_busqueda.RowStyles.Add(new RowStyle(SizeType.Percent, 87.17047F));
            tlp_busqueda.Size = new Size(1184, 753);
            tlp_busqueda.TabIndex = 5;
            // 
            // dgvPacientes
            // 
            dataGridViewCellStyle3.BackColor = Color.FromArgb(224, 224, 224);
            dgvPacientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvPacientes.BackgroundColor = Color.FromArgb(238, 239, 255);
            dgvPacientes.BorderStyle = BorderStyle.None;
            dgvPacientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPacientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Dock = DockStyle.Fill;
            dgvPacientes.EnableHeadersVisualStyles = false;
            dgvPacientes.Location = new Point(10, 107);
            dgvPacientes.Margin = new Padding(10, 11, 10, 11);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.ReadOnly = true;
            dgvPacientes.RowHeadersWidth = 51;
            dgvPacientes.Size = new Size(1151, 635);
            dgvPacientes.TabIndex = 0;
            dgvPacientes.CellContentClick += dgvPacientes_CellContentClick_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1432, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(13, 908);
            panel1.TabIndex = 5;
            // 
            // tlp_busquedanav
            // 
            tlp_busquedanav.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlp_busquedanav.ColumnCount = 2;
            tlp_busquedanav.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_busquedanav.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_busquedanav.Controls.Add(panel_boton, 1, 0);
            tlp_busquedanav.Controls.Add(panel_buscador, 0, 0);
            tlp_busquedanav.Location = new Point(3, 4);
            tlp_busquedanav.Margin = new Padding(3, 4, 3, 4);
            tlp_busquedanav.Name = "tlp_busquedanav";
            tlp_busquedanav.RowCount = 1;
            tlp_busquedanav.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_busquedanav.RowStyles.Add(new RowStyle(SizeType.Absolute, 88F));
            tlp_busquedanav.Size = new Size(1165, 88);
            tlp_busquedanav.TabIndex = 0;
            // 
            // panel_boton
            // 
            panel_boton.Controls.Add(button3);
            panel_boton.Dock = DockStyle.Fill;
            panel_boton.Location = new Point(585, 4);
            panel_boton.Margin = new Padding(3, 4, 3, 4);
            panel_boton.Name = "panel_boton";
            panel_boton.Size = new Size(577, 80);
            panel_boton.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(37, 38, 60);
            button3.Dock = DockStyle.Right;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = Properties.Resources.agregar1;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(304, 0);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Padding = new Padding(29, 0, 0, 0);
            button3.Size = new Size(273, 80);
            button3.TabIndex = 1;
            button3.Text = "    Nuevo Paciente";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel_buscador
            // 
            panel_buscador.Controls.Add(pictureBox2);
            panel_buscador.Controls.Add(txtBuscar);
            panel_buscador.Dock = DockStyle.Fill;
            panel_buscador.Location = new Point(3, 4);
            panel_buscador.Margin = new Padding(3, 4, 3, 4);
            panel_buscador.Name = "panel_buscador";
            panel_buscador.Size = new Size(576, 80);
            panel_buscador.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = Properties.Resources.buscar;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.FromArgb(217, 220, 255);
            txtBuscar.BorderStyle = BorderStyle.None;
            txtBuscar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(89, 23);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(446, 32);
            txtBuscar.TabIndex = 2;
            // 
            // CP_Pacientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 255);
            ClientSize = new Size(1445, 908);
            Controls.Add(panel1);
            Controls.Add(tlp_General);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CP_Pacientes";
            Text = "CP_Pacientes";
            WindowState = FormWindowState.Maximized;
            Load += CP_Pacientes_Load;
            tlp_General.ResumeLayout(false);
            panel_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_nav.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tlp_busqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            tlp_busquedanav.ResumeLayout(false);
            panel_boton.ResumeLayout(false);
            panel_buscador.ResumeLayout(false);
            panel_buscador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlp_General;
        private Panel panel_nav;
        private Panel panel_logo;
        private PictureBox pictureBox1;
        private Panel panel_header;
        private Panel panel4;
        private Button bt_paciente;
        private Panel panel5;
        private Button button2;
        private TableLayoutPanel tlp_busqueda;
        private TableLayoutPanel tlp_busquedanav;
        private Panel panel_boton;
        private Panel panel_buscador;
        private TextBox txtBuscar;
        private PictureBox pictureBox2;
        private DataGridView dgvPacientes;
        private Button button3;
        private Panel panel1;
        private Button bt_config;
        private Button bt_usuario;
    }
}