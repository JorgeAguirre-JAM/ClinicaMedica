namespace CapaPresentacion
{
    partial class CP_Consultas
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
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
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            dgvConsultas = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            p_datos = new Panel();
            dateTimePicker3 = new DateTimePicker();
            label7 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel7 = new Panel();
            button1 = new Button();
            tlp_General.SuspendLayout();
            panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_logo).BeginInit();
            panel_nav.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel_header.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultas).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            p_datos.SuspendLayout();
            panel7.SuspendLayout();
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
            tlp_General.Controls.Add(tableLayoutPanel1, 1, 1);
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
            panel_nav.Controls.Add(panel3);
            panel_nav.Controls.Add(bt_config);
            panel_nav.Controls.Add(panel2);
            panel_nav.Controls.Add(bt_usuario);
            panel_nav.Controls.Add(panel5);
            panel_nav.Controls.Add(panel4);
            panel_nav.Location = new Point(3, 113);
            panel_nav.Name = "panel_nav";
            panel_nav.Size = new Size(217, 565);
            panel_nav.TabIndex = 1;
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
            bt_config.Location = new Point(20, 504);
            bt_config.Name = "bt_config";
            bt_config.Size = new Size(54, 52);
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
            bt_usuario.Location = new Point(147, 504);
            bt_usuario.Name = "bt_usuario";
            bt_usuario.Size = new Size(54, 52);
            bt_usuario.TabIndex = 3;
            bt_usuario.UseVisualStyleBackColor = false;
            bt_usuario.Click += bt_usuario_Click;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(36, 37, 60);
            label2.Location = new Point(10, 28);
            label2.Name = "label2";
            label2.Size = new Size(164, 45);
            label2.TabIndex = 2;
            label2.Text = "Consultas";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Location = new Point(226, 113);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.4377327F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 76.56226F));
            tableLayoutPanel1.Size = new Size(1035, 565);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvConsultas);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 135);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 427);
            panel1.TabIndex = 0;
            // 
            // dgvConsultas
            // 
            dataGridViewCellStyle9.BackColor = Color.FromArgb(224, 224, 224);
            dgvConsultas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dgvConsultas.BackgroundColor = Color.FromArgb(238, 239, 255);
            dgvConsultas.BorderStyle = BorderStyle.None;
            dgvConsultas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvConsultas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvConsultas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultas.Dock = DockStyle.Fill;
            dgvConsultas.EnableHeadersVisualStyles = false;
            dgvConsultas.Location = new Point(0, 0);
            dgvConsultas.Margin = new Padding(9, 8, 9, 8);
            dgvConsultas.Name = "dgvConsultas";
            dgvConsultas.ReadOnly = true;
            dgvConsultas.RowHeadersWidth = 51;
            dgvConsultas.Size = new Size(1029, 427);
            dgvConsultas.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.5471344F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.4528656F));
            tableLayoutPanel2.Controls.Add(p_datos, 0, 0);
            tableLayoutPanel2.Controls.Add(panel7, 1, 0);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1029, 126);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // p_datos
            // 
            p_datos.Controls.Add(dateTimePicker3);
            p_datos.Controls.Add(label7);
            p_datos.Controls.Add(dateTimePicker2);
            p_datos.Controls.Add(dateTimePicker1);
            p_datos.Controls.Add(textBox3);
            p_datos.Controls.Add(textBox2);
            p_datos.Controls.Add(textBox1);
            p_datos.Controls.Add(label6);
            p_datos.Controls.Add(label5);
            p_datos.Controls.Add(label4);
            p_datos.Controls.Add(label3);
            p_datos.Controls.Add(label1);
            p_datos.Location = new Point(3, 3);
            p_datos.Name = "p_datos";
            p_datos.Size = new Size(545, 120);
            p_datos.TabIndex = 0;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(160, 90);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(111, 23);
            dateTimePicker3.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(36, 37, 60);
            label7.Location = new Point(160, 72);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 22;
            label7.Text = "Fecha";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(423, 90);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(111, 23);
            dateTimePicker2.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(291, 90);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(111, 23);
            dateTimePicker1.TabIndex = 20;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(9, 90);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(134, 23);
            textBox3.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(234, 29);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(202, 23);
            textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(9, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 23);
            textBox1.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(36, 37, 60);
            label6.Location = new Point(423, 72);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 16;
            label6.Text = "Salida";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(36, 37, 60);
            label5.Location = new Point(291, 72);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 15;
            label5.Text = "Llegada";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(36, 37, 60);
            label4.Location = new Point(9, 72);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 14;
            label4.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(36, 37, 60);
            label3.Location = new Point(234, 11);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 13;
            label3.Text = "Apellidos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(36, 37, 60);
            label1.Location = new Point(9, 11);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 12;
            label1.Text = "Nombre/s";
            // 
            // panel7
            // 
            panel7.Controls.Add(button1);
            panel7.Location = new Point(554, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(472, 120);
            panel7.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(37, 38, 60);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.agregar1;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(216, 29);
            button1.Margin = new Padding(350, 3, 0, 3);
            button1.Name = "button1";
            button1.Padding = new Padding(25, 0, 0, 0);
            button1.Size = new Size(239, 60);
            button1.TabIndex = 3;
            button1.Text = "    Agregar Consulta";
            button1.UseVisualStyleBackColor = false;
            // 
            // CP_Consultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 255);
            ClientSize = new Size(1264, 681);
            Controls.Add(tlp_General);
            Name = "CP_Consultas";
            Text = "CP_Consultas";
            Load += CP_Consultas_Load;
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
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvConsultas).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            p_datos.ResumeLayout(false);
            p_datos.PerformLayout();
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlp_General;
        private Panel panel_logo;
        private PictureBox pb_logo;
        private Panel panel_nav;
        private Panel panel3;
        private Button bt_consultas;
        private Panel panel2;
        private Button bt_citas;
        private Button bt_config;
        private Button bt_usuario;
        private Panel panel5;
        private Button bt_medico;
        private Panel panel4;
        private Button bt_paciente;
        private Panel panel_header;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private DataGridView dgvConsultas;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel p_datos;
        private DateTimePicker dateTimePicker3;
        private Label label7;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Panel panel7;
        private Button button1;
    }
}