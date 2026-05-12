namespace CapaPresentacion
{
    partial class CP_Login
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label7 = new Label();
            label8 = new Label();
            linkLabel1 = new LinkLabel();
            bt_Ingresar = new Button();
            lb_Usuario = new Label();
            label1 = new Label();
            tb_Usuario = new TextBox();
            tb_Contraseña = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(811, 620);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(36, 37, 60);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 614);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(206, 567);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 22;
            label6.Text = "by Alpha Code";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(142, 548);
            label5.Name = "label5";
            label5.Size = new Size(158, 15);
            label5.TabIndex = 21;
            label5.Text = "Developed and Designed";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.SCCM;
            pictureBox1.Location = new Point(85, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(bt_Ingresar);
            panel2.Controls.Add(lb_Usuario);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(tb_Usuario);
            panel2.Controls.Add(tb_Contraseña);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(327, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(481, 614);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(36, 37, 60);
            label7.Location = new Point(23, 83);
            label7.Name = "label7";
            label7.Size = new Size(141, 32);
            label7.TabIndex = 19;
            label7.Text = "Ingresa tus";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(36, 37, 60);
            label8.Location = new Point(22, 106);
            label8.Name = "label8";
            label8.Size = new Size(241, 50);
            label8.TabIndex = 20;
            label8.Text = "Credenciales";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(175, 444);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(134, 15);
            linkLabel1.TabIndex = 18;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Registrar Nuevo Usuario";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // bt_Ingresar
            // 
            bt_Ingresar.BackColor = Color.FromArgb(36, 37, 60);
            bt_Ingresar.FlatAppearance.BorderSize = 0;
            bt_Ingresar.FlatStyle = FlatStyle.Popup;
            bt_Ingresar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_Ingresar.ForeColor = Color.White;
            bt_Ingresar.Location = new Point(174, 397);
            bt_Ingresar.Name = "bt_Ingresar";
            bt_Ingresar.Size = new Size(137, 39);
            bt_Ingresar.TabIndex = 17;
            bt_Ingresar.Text = "Ingresar";
            bt_Ingresar.UseVisualStyleBackColor = false;
            bt_Ingresar.Click += bt_Ingresar_Click;
            // 
            // lb_Usuario
            // 
            lb_Usuario.AutoSize = true;
            lb_Usuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Usuario.ForeColor = Color.FromArgb(36, 37, 60);
            lb_Usuario.Location = new Point(22, 211);
            lb_Usuario.Name = "lb_Usuario";
            lb_Usuario.Size = new Size(63, 20);
            lb_Usuario.TabIndex = 13;
            lb_Usuario.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(36, 37, 60);
            label1.Location = new Point(22, 305);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 14;
            label1.Text = "Contraseña";
            // 
            // tb_Usuario
            // 
            tb_Usuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_Usuario.BackColor = Color.White;
            tb_Usuario.BorderStyle = BorderStyle.FixedSingle;
            tb_Usuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Usuario.Location = new Point(29, 246);
            tb_Usuario.Name = "tb_Usuario";
            tb_Usuario.Size = new Size(424, 22);
            tb_Usuario.TabIndex = 16;
            // 
            // tb_Contraseña
            // 
            tb_Contraseña.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_Contraseña.BackColor = Color.White;
            tb_Contraseña.BorderStyle = BorderStyle.FixedSingle;
            tb_Contraseña.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Contraseña.Location = new Point(29, 341);
            tb_Contraseña.Name = "tb_Contraseña";
            tb_Contraseña.PasswordChar = '*';
            tb_Contraseña.Size = new Size(424, 22);
            tb_Contraseña.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(146, 332);
            label4.Name = "label4";
            label4.Size = new Size(154, 28);
            label4.TabIndex = 25;
            label4.Text = "Clinica Medica";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(51, 299);
            label2.Name = "label2";
            label2.Size = new Size(249, 28);
            label2.TabIndex = 23;
            label2.Text = "Sistema de Control para";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(160, 271);
            label3.Name = "label3";
            label3.Size = new Size(140, 28);
            label3.TabIndex = 24;
            label3.Text = "Bienvenido, al";
            // 
            // CP_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 255);
            ClientSize = new Size(811, 620);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CP_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CP_Login";
            Load += CP_Login_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label lb_Usuario;
        private Label label1;
        private TextBox tb_Usuario;
        private TextBox tb_Contraseña;
        private Button bt_Ingresar;
        private LinkLabel linkLabel1;
        private Label label7;
        private Label label8;
        private Label label4;
        private Label label2;
        private Label label3;
    }
}