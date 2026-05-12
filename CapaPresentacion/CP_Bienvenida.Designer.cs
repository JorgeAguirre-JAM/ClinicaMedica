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
            tlp_General.Margin = new Padding(3, 4, 3, 4);
            tlp_General.Name = "tlp_General";
            tlp_General.RowCount = 2;
            tlp_General.RowStyles.Add(new RowStyle(SizeType.Percent, 16.22807F));
            tlp_General.RowStyles.Add(new RowStyle(SizeType.Percent, 83.77193F));
            tlp_General.Size = new Size(1445, 908);
            tlp_General.TabIndex = 2;
            // 
            // panel_logo
            // 
            panel_logo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_logo.BackColor = Color.FromArgb(36, 37, 60);
            panel_logo.Controls.Add(pb_logo);
            panel_logo.Location = new Point(3, 4);
            panel_logo.Margin = new Padding(3, 4, 3, 4);
            panel_logo.Name = "panel_logo";
            panel_logo.Size = new Size(249, 139);
            panel_logo.TabIndex = 2;
            // 
            // pb_logo
            // 
            pb_logo.Image = Properties.Resources.SCCM_lineal_2;
            pb_logo.Location = new Point(23, 16);
            pb_logo.Margin = new Padding(3, 4, 3, 4);
            pb_logo.Name = "pb_logo";
            pb_logo.Size = new Size(207, 104);
            pb_logo.SizeMode = PictureBoxSizeMode.Zoom;
            pb_logo.TabIndex = 0;
            pb_logo.TabStop = false;
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
            // 
            // bt_config
            // 
            bt_config.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bt_config.FlatAppearance.BorderSize = 0;
            bt_config.FlatStyle = FlatStyle.Flat;
            bt_config.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_config.ForeColor = Color.White;
            bt_config.Image = Properties.Resources.config;
            bt_config.Location = new Point(23, 675);
            bt_config.Margin = new Padding(3, 4, 3, 4);
            bt_config.Name = "bt_config";
            bt_config.Size = new Size(44, 53);
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
            bt_usuario.Location = new Point(183, 675);
            bt_usuario.Margin = new Padding(3, 4, 3, 4);
            bt_usuario.Name = "bt_usuario";
            bt_usuario.Size = new Size(44, 53);
            bt_usuario.TabIndex = 1;
            bt_usuario.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(bt_medico);
            panel5.Location = new Point(23, 181);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(203, 84);
            panel5.TabIndex = 1;
            // 
            // bt_medico
            // 
            bt_medico.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bt_medico.FlatAppearance.BorderSize = 0;
            bt_medico.FlatStyle = FlatStyle.Flat;
            bt_medico.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_medico.ForeColor = Color.White;
            bt_medico.Image = Properties.Resources.dcotor_icon2;
            bt_medico.ImageAlign = ContentAlignment.MiddleLeft;
            bt_medico.Location = new Point(3, 4);
            bt_medico.Margin = new Padding(3, 4, 3, 4);
            bt_medico.Name = "bt_medico";
            bt_medico.Padding = new Padding(29, 0, 0, 0);
            bt_medico.Size = new Size(197, 76);
            bt_medico.TabIndex = 0;
            bt_medico.Text = "    Medico";
            bt_medico.UseVisualStyleBackColor = true;
            bt_medico.Click += bt_medico_Click;
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
            panel1.Location = new Point(258, 151);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1184, 753);
            panel1.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(40, 353);
            label7.Name = "label7";
            label7.Size = new Size(345, 28);
            label7.TabIndex = 6;
            label7.Text = "Selecciona una opción para comenzar.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(40, 325);
            label6.Name = "label6";
            label6.Size = new Size(776, 28);
            label6.TabIndex = 5;
            label6.Text = "necesites. Desde aquí podrás realizar diversas acciones de forma rápida, clara y eficiente.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(40, 297);
            label5.Name = "label5";
            label5.Size = new Size(872, 28);
            label5.TabIndex = 4;
            label5.Text = "Utiliza el menú lateral para navegar entre las opciones disponibles y acceder a las herramientas que";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(40, 237);
            label4.Name = "label4";
            label4.Size = new Size(113, 28);
            label4.TabIndex = 3;
            label4.Text = "del sistema.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(40, 209);
            label3.Name = "label3";
            label3.Size = new Size(920, 28);
            label3.TabIndex = 2;
            label3.Text = "Esta plataforma ha sido diseñada para facilitar la gestión y organización de las distintas funciones dentro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(40, 157);
            label2.Name = "label2";
            label2.Size = new Size(449, 28);
            label2.TabIndex = 1;
            label2.Text = "Al Sistema de Control para Clínica Médica (SCCM).";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(36, 37, 60);
            label1.Location = new Point(24, 49);
            label1.Name = "label1";
            label1.Size = new Size(413, 89);
            label1.TabIndex = 0;
            label1.Text = "Bienvenid@";
            // 
            // CP_Bienvenida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 255);
            ClientSize = new Size(1445, 908);
            Controls.Add(tlp_General);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}