namespace CapaPresentacion
{
    partial class CP_Medico
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
            pb_logo = new PictureBox();
            panel_nav = new Panel();
            panel3 = new Panel();
            bt_consultas = new Button();
            panel2 = new Panel();
            bt_citas = new Button();
            bt_config = new Button();
            bt_usuario = new Button();
            panel5 = new Panel();
            bt_medico = new Button();
            panel4 = new Panel();
            bt_paciente = new Button();
            panel_header = new Panel();
            tlp_busqueda = new TableLayoutPanel();
            dgvMedico = new DataGridView();
            tlp_busquedanav = new TableLayoutPanel();
            panel_boton = new Panel();
            button1 = new Button();
            bt_agregarmedico = new Button();
            panel_buscador = new Panel();
            pictureBox2 = new PictureBox();
            txtBuscar = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            tlp_General.SuspendLayout();
            panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_logo).BeginInit();
            panel_nav.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel_header.SuspendLayout();
            tlp_busqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMedico).BeginInit();
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
            tlp_General.Name = "tlp_General";
            tlp_General.RowCount = 2;
            tlp_General.RowStyles.Add(new RowStyle(SizeType.Percent, 16.22807F));
            tlp_General.RowStyles.Add(new RowStyle(SizeType.Percent, 83.77193F));
            tlp_General.Size = new Size(1264, 681);
            tlp_General.TabIndex = 1;
            // 
            // panel_logo
            // 
            panel_logo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_logo.BackColor = Color.FromArgb(36, 37, 60);
            panel_logo.Controls.Add(pb_logo);
            panel_logo.Location = new Point(3, 3);
            panel_logo.Name = "panel_logo";
            panel_logo.Size = new Size(217, 104);
            panel_logo.TabIndex = 2;
            // 
            // pb_logo
            // 
            pb_logo.Image = Properties.Resources.SCCM_lineal_2;
            pb_logo.Location = new Point(20, 12);
            pb_logo.Name = "pb_logo";
            pb_logo.Size = new Size(181, 78);
            pb_logo.SizeMode = PictureBoxSizeMode.Zoom;
            pb_logo.TabIndex = 0;
            pb_logo.TabStop = false;
            // 
            // panel_nav
            // 
            panel_nav.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_nav.BackColor = Color.FromArgb(36, 37, 60);
            panel_nav.Controls.Add(panel3);
            panel_nav.Controls.Add(panel2);
            panel_nav.Controls.Add(bt_config);
            panel_nav.Controls.Add(bt_usuario);
            panel_nav.Controls.Add(panel5);
            panel_nav.Controls.Add(panel4);
            panel_nav.Location = new Point(3, 113);
            panel_nav.Name = "panel_nav";
            panel_nav.Size = new Size(217, 565);
            panel_nav.TabIndex = 1;
            panel_nav.Paint += panel_nav_Paint;
            // 
            // panel3
            // 
            panel3.Controls.Add(bt_consultas);
            panel3.Location = new Point(20, 307);
            panel3.Name = "panel3";
            panel3.Size = new Size(178, 63);
            panel3.TabIndex = 5;
            // 
            // bt_consultas
            // 
            bt_consultas.BackColor = Color.FromArgb(52, 57, 91);
            bt_consultas.Dock = DockStyle.Fill;
            bt_consultas.FlatAppearance.BorderSize = 0;
            bt_consultas.FlatStyle = FlatStyle.Flat;
            bt_consultas.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_consultas.ForeColor = Color.White;
            bt_consultas.Image = Properties.Resources.consultasog;
            bt_consultas.ImageAlign = ContentAlignment.MiddleLeft;
            bt_consultas.Location = new Point(0, 0);
            bt_consultas.Name = "bt_consultas";
            bt_consultas.Padding = new Padding(25, 0, 0, 0);
            bt_consultas.Size = new Size(178, 63);
            bt_consultas.TabIndex = 0;
            bt_consultas.Text = "    Consultas";
            bt_consultas.UseVisualStyleBackColor = false;
            bt_consultas.Click += bt_consultas_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(bt_citas);
            panel2.Location = new Point(20, 219);
            panel2.Name = "panel2";
            panel2.Size = new Size(178, 63);
            panel2.TabIndex = 2;
            // 
            // bt_citas
            // 
            bt_citas.BackColor = Color.FromArgb(52, 57, 91);
            bt_citas.Dock = DockStyle.Fill;
            bt_citas.FlatAppearance.BorderSize = 0;
            bt_citas.FlatStyle = FlatStyle.Flat;
            bt_citas.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_citas.ForeColor = Color.White;
            bt_citas.Image = Properties.Resources.citasog;
            bt_citas.ImageAlign = ContentAlignment.MiddleLeft;
            bt_citas.Location = new Point(0, 0);
            bt_citas.Name = "bt_citas";
            bt_citas.Padding = new Padding(25, 0, 0, 0);
            bt_citas.Size = new Size(178, 63);
            bt_citas.TabIndex = 0;
            bt_citas.Text = "    Citas";
            bt_citas.UseVisualStyleBackColor = false;
            // 
            // bt_config
            // 
            bt_config.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bt_config.FlatAppearance.BorderSize = 0;
            bt_config.FlatStyle = FlatStyle.Flat;
            bt_config.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_config.ForeColor = Color.White;
            bt_config.Image = Properties.Resources.config1;
            bt_config.Location = new Point(17, 506);
            bt_config.Name = "bt_config";
            bt_config.Size = new Size(37, 40);
            bt_config.TabIndex = 4;
            bt_config.UseVisualStyleBackColor = true;
            // 
            // bt_usuario
            // 
            bt_usuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bt_usuario.BackColor = Color.FromArgb(52, 57, 91);
            bt_usuario.FlatAppearance.BorderSize = 0;
            bt_usuario.FlatStyle = FlatStyle.Flat;
            bt_usuario.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_usuario.ForeColor = Color.White;
            bt_usuario.Image = Properties.Resources.paciente;
            bt_usuario.Location = new Point(157, 506);
            bt_usuario.Name = "bt_usuario";
            bt_usuario.Size = new Size(37, 40);
            bt_usuario.TabIndex = 3;
            bt_usuario.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(bt_medico);
            panel5.Location = new Point(20, 136);
            panel5.Name = "panel5";
            panel5.Size = new Size(178, 63);
            panel5.TabIndex = 1;
            // 
            // bt_medico
            // 
            bt_medico.BackColor = Color.FromArgb(52, 57, 91);
            bt_medico.Dock = DockStyle.Fill;
            bt_medico.FlatAppearance.BorderSize = 0;
            bt_medico.FlatStyle = FlatStyle.Flat;
            bt_medico.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_medico.ForeColor = Color.White;
            bt_medico.Image = Properties.Resources.medicoog;
            bt_medico.ImageAlign = ContentAlignment.MiddleLeft;
            bt_medico.Location = new Point(0, 0);
            bt_medico.Name = "bt_medico";
            bt_medico.Padding = new Padding(25, 0, 0, 0);
            bt_medico.Size = new Size(178, 63);
            bt_medico.TabIndex = 0;
            bt_medico.Text = "    Medico";
            bt_medico.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(bt_paciente);
            panel4.Location = new Point(20, 56);
            panel4.Name = "panel4";
            panel4.Size = new Size(178, 63);
            panel4.TabIndex = 0;
            // 
            // bt_paciente
            // 
            bt_paciente.BackColor = Color.FromArgb(52, 57, 91);
            bt_paciente.Dock = DockStyle.Fill;
            bt_paciente.FlatAppearance.BorderSize = 0;
            bt_paciente.FlatStyle = FlatStyle.Flat;
            bt_paciente.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_paciente.ForeColor = Color.White;
            bt_paciente.Image = Properties.Resources.pacienteog;
            bt_paciente.ImageAlign = ContentAlignment.MiddleLeft;
            bt_paciente.Location = new Point(0, 0);
            bt_paciente.Name = "bt_paciente";
            bt_paciente.Padding = new Padding(25, 0, 0, 0);
            bt_paciente.Size = new Size(178, 63);
            bt_paciente.TabIndex = 0;
            bt_paciente.Text = "     Paciente";
            bt_paciente.UseVisualStyleBackColor = false;
            bt_paciente.Click += bt_paciente_Click;
            // 
            // panel_header
            // 
            panel_header.Controls.Add(label2);
            panel_header.Dock = DockStyle.Fill;
            panel_header.Location = new Point(226, 3);
            panel_header.Name = "panel_header";
            panel_header.Size = new Size(1035, 104);
            panel_header.TabIndex = 4;
            // 
            // tlp_busqueda
            // 
            tlp_busqueda.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tlp_busqueda.ColumnCount = 2;
            tlp_busqueda.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp_busqueda.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 12F));
            tlp_busqueda.Controls.Add(dgvMedico, 0, 1);
            tlp_busqueda.Controls.Add(tlp_busquedanav, 0, 0);
            tlp_busqueda.Dock = DockStyle.Fill;
            tlp_busqueda.Location = new Point(226, 113);
            tlp_busqueda.Name = "tlp_busqueda";
            tlp_busqueda.RowCount = 2;
            tlp_busqueda.RowStyles.Add(new RowStyle(SizeType.Percent, 12.8295259F));
            tlp_busqueda.RowStyles.Add(new RowStyle(SizeType.Percent, 87.17047F));
            tlp_busqueda.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp_busqueda.Size = new Size(1035, 565);
            tlp_busqueda.TabIndex = 5;
            tlp_busqueda.Paint += tlp_busqueda_Paint;
            // 
            // dgvMedico
            // 
            dataGridViewCellStyle3.BackColor = Color.FromArgb(224, 224, 224);
            dgvMedico.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvMedico.BackgroundColor = Color.FromArgb(238, 239, 255);
            dgvMedico.BorderStyle = BorderStyle.None;
            dgvMedico.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMedico.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvMedico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvMedico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedico.Dock = DockStyle.Fill;
            dgvMedico.EnableHeadersVisualStyles = false;
            dgvMedico.Location = new Point(10, 82);
            dgvMedico.Margin = new Padding(9, 8, 9, 8);
            dgvMedico.Name = "dgvMedico";
            dgvMedico.ReadOnly = true;
            dgvMedico.RowHeadersWidth = 51;
            dgvMedico.Size = new Size(1002, 474);
            dgvMedico.TabIndex = 1;
            dgvMedico.CellContentClick += dgvMedico_CellContentClick;
            // 
            // tlp_busquedanav
            // 
            tlp_busquedanav.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlp_busquedanav.ColumnCount = 2;
            tlp_busquedanav.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_busquedanav.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_busquedanav.Controls.Add(panel_boton, 1, 0);
            tlp_busquedanav.Controls.Add(panel_buscador, 0, 0);
            tlp_busquedanav.Location = new Point(4, 4);
            tlp_busquedanav.Name = "tlp_busquedanav";
            tlp_busquedanav.RowCount = 1;
            tlp_busquedanav.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_busquedanav.RowStyles.Add(new RowStyle(SizeType.Absolute, 66F));
            tlp_busquedanav.Size = new Size(1014, 66);
            tlp_busquedanav.TabIndex = 0;
            // 
            // panel_boton
            // 
            panel_boton.Controls.Add(button1);
            panel_boton.Controls.Add(bt_agregarmedico);
            panel_boton.Dock = DockStyle.Fill;
            panel_boton.Location = new Point(510, 3);
            panel_boton.Name = "panel_boton";
            panel_boton.Padding = new Padding(175, 0, 0, 0);
            panel_boton.Size = new Size(501, 60);
            panel_boton.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(37, 38, 60);
            button1.Dock = DockStyle.Left;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.agregar1;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(175, 0);
            button1.Margin = new Padding(350, 3, 0, 3);
            button1.Name = "button1";
            button1.Padding = new Padding(25, 0, 0, 0);
            button1.Size = new Size(239, 60);
            button1.TabIndex = 2;
            button1.Text = "    Nueva Especialidad";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // bt_agregarmedico
            // 
            bt_agregarmedico.BackColor = Color.FromArgb(37, 38, 60);
            bt_agregarmedico.Dock = DockStyle.Right;
            bt_agregarmedico.FlatAppearance.BorderSize = 0;
            bt_agregarmedico.FlatStyle = FlatStyle.Flat;
            bt_agregarmedico.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_agregarmedico.ForeColor = Color.White;
            bt_agregarmedico.Image = Properties.Resources.agregar1;
            bt_agregarmedico.ImageAlign = ContentAlignment.MiddleLeft;
            bt_agregarmedico.Location = new Point(262, 0);
            bt_agregarmedico.Margin = new Padding(35, 3, 35, 3);
            bt_agregarmedico.Name = "bt_agregarmedico";
            bt_agregarmedico.Size = new Size(239, 60);
            bt_agregarmedico.TabIndex = 1;
            bt_agregarmedico.Text = "    Nuevo Medico";
            bt_agregarmedico.UseVisualStyleBackColor = false;
            bt_agregarmedico.Click += bt_agregarmedico_Click;
            // 
            // panel_buscador
            // 
            panel_buscador.Controls.Add(pictureBox2);
            panel_buscador.Controls.Add(txtBuscar);
            panel_buscador.Dock = DockStyle.Fill;
            panel_buscador.Location = new Point(3, 3);
            panel_buscador.Name = "panel_buscador";
            panel_buscador.Size = new Size(501, 60);
            panel_buscador.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = Properties.Resources.buscar;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.White;
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(78, 13);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(390, 33);
            txtBuscar.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1255, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(9, 681);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(36, 37, 60);
            label2.Location = new Point(10, 28);
            label2.Name = "label2";
            label2.Size = new Size(204, 45);
            label2.TabIndex = 2;
            label2.Text = "Especialidad";
            // 
            // CP_Medico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 255);
            ClientSize = new Size(1264, 681);
            Controls.Add(panel1);
            Controls.Add(tlp_General);
            Name = "CP_Medico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CP_Medico";
            WindowState = FormWindowState.Maximized;
            Load += CP_Medico_Load;
            tlp_General.ResumeLayout(false);
            panel_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_logo).EndInit();
            panel_nav.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel_header.ResumeLayout(false);
            panel_header.PerformLayout();
            tlp_busqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMedico).EndInit();
            tlp_busquedanav.ResumeLayout(false);
            panel_boton.ResumeLayout(false);
            panel_buscador.ResumeLayout(false);
            panel_buscador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlp_General;
        private Panel panel_logo;
        private PictureBox pb_logo;
        private Panel panel_nav;
        private Panel panel5;
        private Button bt_medico;
        private Panel panel4;
        private Button bt_paciente;
        private Panel panel_header;
        private TableLayoutPanel tlp_busqueda;
        private Panel panel1;
        private TableLayoutPanel tlp_busquedanav;
        private Panel panel_boton;
        private Button bt_agregarmedico;
        private Panel panel_buscador;
        private PictureBox pictureBox2;
        private TextBox txtBuscar;
        private DataGridView dgvMedico;
        private Button bt_config;
        private Button bt_usuario;
        private Button button1;
        private Panel panel3;
        private Button bt_consultas;
        private Panel panel2;
        private Button bt_citas;
        private Label label2;
    }
}