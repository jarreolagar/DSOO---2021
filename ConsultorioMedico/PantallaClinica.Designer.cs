namespace ConsultorioMedico
{
    partial class PantallaClinica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaClinica));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreClinica = new System.Windows.Forms.TextBox();
            this.txtDireccionClinica = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dataGridClinica = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscarClinica = new System.Windows.Forms.TextBox();
            this.labelid = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClinica)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administración de Clínicas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(379, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clínica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dirección";
            // 
            // txtNombreClinica
            // 
            this.txtNombreClinica.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreClinica.Location = new System.Drawing.Point(123, 92);
            this.txtNombreClinica.Name = "txtNombreClinica";
            this.txtNombreClinica.Size = new System.Drawing.Size(220, 27);
            this.txtNombreClinica.TabIndex = 4;
            // 
            // txtDireccionClinica
            // 
            this.txtDireccionClinica.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionClinica.Location = new System.Drawing.Point(123, 129);
            this.txtDireccionClinica.Name = "txtDireccionClinica";
            this.txtDireccionClinica.Size = new System.Drawing.Size(220, 27);
            this.txtDireccionClinica.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(34, 252);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(104, 28);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(34, 306);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(104, 29);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(35, 354);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 29);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dataGridClinica
            // 
            this.dataGridClinica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClinica.Location = new System.Drawing.Point(176, 251);
            this.dataGridClinica.Name = "dataGridClinica";
            this.dataGridClinica.Size = new System.Drawing.Size(406, 150);
            this.dataGridClinica.TabIndex = 10;
            this.dataGridClinica.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClinica_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Buscar";
            // 
            // txtBuscarClinica
            // 
            this.txtBuscarClinica.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarClinica.Location = new System.Drawing.Point(123, 179);
            this.txtBuscarClinica.Name = "txtBuscarClinica";
            this.txtBuscarClinica.Size = new System.Drawing.Size(220, 27);
            this.txtBuscarClinica.TabIndex = 12;
            this.txtBuscarClinica.TextChanged += new System.EventHandler(this.txtBuscarClinica_TextChanged);
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(116, 68);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(35, 13);
            this.labelid.TabIndex = 13;
            this.labelid.Text = "label5";
            this.labelid.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(12, 177);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(104, 28);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // PantallaClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(613, 432);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.txtBuscarClinica);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridClinica);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDireccionClinica);
            this.Controls.Add(this.txtNombreClinica);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "PantallaClinica";
            this.Text = "PantallaClinica";
            this.Load += new System.EventHandler(this.PantallaClinica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClinica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreClinica;
        private System.Windows.Forms.TextBox txtDireccionClinica;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dataGridClinica;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscarClinica;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Button btnBuscar;
    }
}