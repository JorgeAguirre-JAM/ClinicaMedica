namespace CapaPresentacion
{
    partial class CP_Bienvenida
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
            tlp_General = new TableLayoutPanel();
            panel_logo = new Panel();
            pb_logo = new PictureBox();
            panel_nav = new Panel();
            bt_config = new Button();
            bt_usuario = new Button();
            panel5 = new Panel();
            bt_medico = new Button();
            panel4 = new Panel();
            bt_paciente = new Button();
            panel_header = new Panel();
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            bt_consultas = new Button();
            bt_citas = new Button();
            tlp_General.SuspendLayout();
            panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_logo).BeginInit();
            panel_nav.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
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
            tlp_General.Controls.Add(panel1, 1, 1);
            tlp_General.Dock = DockStyle.Fill;
            tlp_General.Location = new Point(0, 0);
            tlp_General.Name = "tlp_General";
            tlp_General.RowCount = 2;
            tlp_General.RowStyles.Add(new RowStyle(SizeType.Percent, 16.22807F));
            tlp_General.RowStyles.Add(new RowStyle(SizeType.Percent, 83.77193F));
            tlp_General.Size = new Size(1264, 681);
            tlp_General.TabIndex = 2;
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
            panel_nav.Controls.Add(bt_consultas);
            panel_nav.Controls.Add(bt_citas);
            panel_nav.Controls.Add(bt_config);
            panel_nav.Controls.Add(bt_usuario);
            panel_nav.Controls.Add(panel5);
            panel_nav.Controls.Add(panel4);
            panel_nav.Location = new Point(3, 113);
            panel_nav.Name = "panel_nav";
            panel_nav.Size = new Size(217, 565);
            panel_nav.TabIndex = 1;
            // 
            // bt_config
            // 
            bt_config.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bt_config.FlatAppearance.BorderSize = 0;
            bt_config.FlatStyle = FlatStyle.Flat;
            bt_config.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_config.ForeColor = Color.White;
            bt_config.Image = Properties.Resources.config;
            bt_config.Location = new Point(20, 506);
            bt_config.Name = "bt_config";
            bt_config.Size = new Size(37, 40);
            bt_config.TabIndex = 2;
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
            bt_usuario.Location = new Point(160, 506);
            bt_usuario.Name = "bt_usuario";
            bt_usuario.Size = new Size(37, 40);
            bt_usuario.TabIndex = 1;
            bt_usuario.UseVisualStyleBackColor = true;
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
            bt_medico.Click += bt_medico_Click;
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
            panel_header.Dock = DockStyle.Fill;
            panel_header.Location = new Point(226, 3);
            panel_header.Name = "panel_header";
            panel_header.Size = new Size(1035, 104);
            panel_header.TabIndex = 4;
            panel_header.Paint += panel_header_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(226, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(1035, 565);
            panel1.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(35, 265);
            label7.Name = "label7";
            label7.Size = new Size(274, 21);
            label7.TabIndex = 6;
            label7.Text = "Selecciona una opción para comenzar.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(35, 244);
            label6.Name = "label6";
            label6.Size = new Size(620, 21);
            label6.TabIndex = 5;
            label6.Text = "necesites. Desde aquí podrás realizar diversas acciones de forma rápida, clara y eficiente.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(35, 223);
            label5.Name = "label5";
            label5.Size = new Size(697, 21);
            label5.TabIndex = 4;
            label5.Text = "Utiliza el menú lateral para navegar entre las opciones disponibles y acceder a las herramientas que";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(35, 178);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 3;
            label4.Text = "del sistema.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(35, 157);
            label3.Name = "label3";
            label3.Size = new Size(731, 21);
            label3.TabIndex = 2;
            label3.Text = "Esta plataforma ha sido diseñada para facilitar la gestión y organización de las distintas funciones dentro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(35, 118);
            label2.Name = "label2";
            label2.Size = new Size(359, 21);
            label2.TabIndex = 1;
            label2.Text = "Al Sistema de Control para Clínica Médica (SCCM).";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(36, 37, 60);
            label1.Location = new Point(21, 37);
            label1.Name = "label1";
            label1.Size = new Size(328, 71);
            label1.TabIndex = 0;
            label1.Text = "Bienvenid@";
            // 
            // bt_consultas
            // 
            bt_consultas.BackColor = Color.FromArgb(52, 57, 91);
            bt_consultas.FlatAppearance.BorderSize = 0;
            bt_consultas.FlatStyle = FlatStyle.Flat;
            bt_consultas.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_consultas.ForeColor = Color.White;
            bt_consultas.Image = Properties.Resources.consultasog;
            bt_consultas.ImageAlign = ContentAlignment.MiddleLeft;
            bt_consultas.Location = new Point(20, 302);
            bt_consultas.Name = "bt_consultas";
            bt_consultas.Padding = new Padding(25, 0, 0, 0);
            bt_consultas.Size = new Size(178, 63);
            bt_consultas.TabIndex = 3;
            bt_consultas.Text = "    Consultas";
            bt_consultas.UseVisualStyleBackColor = false;
            // 
            // bt_citas
            // 
            bt_citas.BackColor = Color.FromArgb(52, 57, 91);
            bt_citas.FlatAppearance.BorderSize = 0;
            bt_citas.FlatStyle = FlatStyle.Flat;
            bt_citas.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_citas.ForeColor = Color.White;
            bt_citas.Image = Properties.Resources.citasog;
            bt_citas.ImageAlign = ContentAlignment.MiddleLeft;
            bt_citas.Location = new Point(20, 219);
            bt_citas.Name = "bt_citas";
            bt_citas.Padding = new Padding(25, 0, 0, 0);
            bt_citas.Size = new Size(178, 63);
            bt_citas.TabIndex = 4;
            bt_citas.Text = "    Citas";
            bt_citas.UseVisualStyleBackColor = false;
            // 
            // CP_Bienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 255);
            ClientSize = new Size(1264, 681);
            Controls.Add(tlp_General);
            Name = "CP_Bienvenida";
            Text = "CP_Bienvenida";
            WindowState = FormWindowState.Maximized;
            tlp_General.ResumeLayout(false);
            panel_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_logo).EndInit();
            panel_nav.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Label label1;
        private Button bt_config;
        private Button bt_usuario;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button bt_consultas;
        private Button bt_citas;
    }
}