namespace CapaPresentacion
{
    partial class ucEspecialidadAgregar
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
            dataGridView1 = new DataGridView();
            bt_guardaresp = new Button();
            tb_aggdescresp = new TextBox();
            tb_aggenombreesp = new TextBox();
            label7 = new Label();
            label3 = new Label();
            tlp_EdicionPa.SuspendLayout();
            panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_edicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            tlp_EdicionPa.TabIndex = 2;
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
            pictureBox1.Image = Properties.Resources.dsfsdf;
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
            label1.Location = new Point(131, 20);
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
            label2.Size = new Size(255, 54);
            label2.TabIndex = 1;
            label2.Text = "Especialidad";
            // 
            // panel_edicion
            // 
            panel_edicion.BackColor = Color.FromArgb(248, 249, 255);
            panel_edicion.Controls.Add(dataGridView1);
            panel_edicion.Controls.Add(bt_guardaresp);
            panel_edicion.Controls.Add(tb_aggdescresp);
            panel_edicion.Controls.Add(tb_aggenombreesp);
            panel_edicion.Controls.Add(label7);
            panel_edicion.Controls.Add(label3);
            panel_edicion.Dock = DockStyle.Fill;
            panel_edicion.Location = new Point(3, 125);
            panel_edicion.Margin = new Padding(3, 4, 3, 4);
            panel_edicion.Name = "panel_edicion";
            panel_edicion.Size = new Size(451, 631);
            panel_edicion.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(238, 239, 255);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 297);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(383, 200);
            dataGridView1.TabIndex = 25;
            // 
            // bt_guardaresp
            // 
            bt_guardaresp.BackColor = Color.FromArgb(37, 38, 60);
            bt_guardaresp.FlatAppearance.BorderSize = 0;
            bt_guardaresp.FlatStyle = FlatStyle.Flat;
            bt_guardaresp.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_guardaresp.ForeColor = Color.White;
            bt_guardaresp.ImageAlign = ContentAlignment.MiddleLeft;
            bt_guardaresp.Location = new Point(131, 533);
            bt_guardaresp.Margin = new Padding(3, 4, 3, 4);
            bt_guardaresp.Name = "bt_guardaresp";
            bt_guardaresp.Size = new Size(185, 59);
            bt_guardaresp.TabIndex = 24;
            bt_guardaresp.Text = "Guardar";
            bt_guardaresp.UseVisualStyleBackColor = false;
            bt_guardaresp.Click += bt_guardaresp_Click;
            // 
            // tb_aggdescresp
            // 
            tb_aggdescresp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_aggdescresp.BackColor = Color.FromArgb(217, 220, 255);
            tb_aggdescresp.BorderStyle = BorderStyle.None;
            tb_aggdescresp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_aggdescresp.Location = new Point(38, 137);
            tb_aggdescresp.Margin = new Padding(3, 4, 3, 4);
            tb_aggdescresp.Multiline = true;
            tb_aggdescresp.Name = "tb_aggdescresp";
            tb_aggdescresp.Size = new Size(384, 128);
            tb_aggdescresp.TabIndex = 20;
            // 
            // tb_aggenombreesp
            // 
            tb_aggenombreesp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_aggenombreesp.BackColor = Color.FromArgb(217, 220, 255);
            tb_aggenombreesp.BorderStyle = BorderStyle.None;
            tb_aggenombreesp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_aggenombreesp.Location = new Point(141, 61);
            tb_aggenombreesp.Margin = new Padding(3, 4, 3, 4);
            tb_aggenombreesp.Name = "tb_aggenombreesp";
            tb_aggenombreesp.Size = new Size(190, 27);
            tb_aggenombreesp.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(36, 37, 60);
            label7.Location = new Point(186, 108);
            label7.Name = "label7";
            label7.Size = new Size(103, 23);
            label7.TabIndex = 4;
            label7.Text = "Descripción";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(36, 37, 60);
            label3.Location = new Point(136, 17);
            label3.Name = "label3";
            label3.Size = new Size(205, 23);
            label3.TabIndex = 0;
            label3.Text = "Nombre de Especialidad";
            // 
            // ucEspecialidadAgregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlp_EdicionPa);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ucEspecialidadAgregar";
            Size = new Size(457, 760);
            tlp_EdicionPa.ResumeLayout(false);
            panel_header.ResumeLayout(false);
            panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_edicion.ResumeLayout(false);
            panel_edicion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlp_EdicionPa;
        private Panel panel_header;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Panel panel_edicion;
        private Button bt_guardaresp;
        private TextBox tb_aggdescresp;
        private TextBox tb_aggenombreesp;
        private Label label3;
        private Label label7;
        private DataGridView dataGridView1;
    }
}
