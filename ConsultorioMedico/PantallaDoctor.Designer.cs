namespace ConsultorioMedico
{
    partial class PantallaDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaDoctor));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNomDoc = new System.Windows.Forms.Label();
            this.lblApDoctor = new System.Windows.Forms.Label();
            this.lblEdDoctor = new System.Windows.Forms.Label();
            this.lblUniversidad = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.txtNombreDoc = new System.Windows.Forms.TextBox();
            this.txtApellidoDoc = new System.Windows.Forms.TextBox();
            this.txtEdadDoc = new System.Windows.Forms.TextBox();
            this.txtUniversidadDoc = new System.Windows.Forms.TextBox();
            this.lblEspDoctor = new System.Windows.Forms.Label();
            this.btnGuardarDoctor = new System.Windows.Forms.Button();
            this.btnEliminarDoctor = new System.Windows.Forms.Button();
            this.btnModificarDoctor = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.txtBuscarDoctor = new System.Windows.Forms.TextBox();
            this.dgvDoc = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBuscarDoc = new System.Windows.Forms.Label();
            this.lblClinica = new System.Windows.Forms.Label();
            this.cmbClinica = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(88, 33);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(308, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Administración de Doctores";
            // 
            // lblNomDoc
            // 
            this.lblNomDoc.AutoSize = true;
            this.lblNomDoc.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomDoc.Location = new System.Drawing.Point(36, 95);
            this.lblNomDoc.Name = "lblNomDoc";
            this.lblNomDoc.Size = new System.Drawing.Size(78, 22);
            this.lblNomDoc.TabIndex = 1;
            this.lblNomDoc.Text = "Nombre";
            // 
            // lblApDoctor
            // 
            this.lblApDoctor.AutoSize = true;
            this.lblApDoctor.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApDoctor.Location = new System.Drawing.Point(36, 129);
            this.lblApDoctor.Name = "lblApDoctor";
            this.lblApDoctor.Size = new System.Drawing.Size(79, 22);
            this.lblApDoctor.TabIndex = 2;
            this.lblApDoctor.Text = "Apellido";
            // 
            // lblEdDoctor
            // 
            this.lblEdDoctor.AutoSize = true;
            this.lblEdDoctor.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdDoctor.Location = new System.Drawing.Point(36, 164);
            this.lblEdDoctor.Name = "lblEdDoctor";
            this.lblEdDoctor.Size = new System.Drawing.Size(50, 22);
            this.lblEdDoctor.TabIndex = 3;
            this.lblEdDoctor.Text = "Edad";
            // 
            // lblUniversidad
            // 
            this.lblUniversidad.AutoSize = true;
            this.lblUniversidad.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniversidad.Location = new System.Drawing.Point(36, 249);
            this.lblUniversidad.Name = "lblUniversidad";
            this.lblUniversidad.Size = new System.Drawing.Size(106, 22);
            this.lblUniversidad.TabIndex = 5;
            this.lblUniversidad.Text = "Universidad";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Items.AddRange(new object[] {
            "Psiquiatría",
            "Cardiología",
            "Neumología",
            "Pediatría",
            "Oncología",
            "Oftalmología",
            "Dermatología"});
            this.cmbEspecialidad.Location = new System.Drawing.Point(179, 201);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(259, 29);
            this.cmbEspecialidad.TabIndex = 7;
            // 
            // txtNombreDoc
            // 
            this.txtNombreDoc.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDoc.Location = new System.Drawing.Point(179, 92);
            this.txtNombreDoc.Name = "txtNombreDoc";
            this.txtNombreDoc.Size = new System.Drawing.Size(259, 29);
            this.txtNombreDoc.TabIndex = 8;
            this.txtNombreDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreDoc_KeyPress);
            // 
            // txtApellidoDoc
            // 
            this.txtApellidoDoc.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoDoc.Location = new System.Drawing.Point(179, 130);
            this.txtApellidoDoc.Name = "txtApellidoDoc";
            this.txtApellidoDoc.Size = new System.Drawing.Size(259, 29);
            this.txtApellidoDoc.TabIndex = 9;
            this.txtApellidoDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoDoc_KeyPress);
            // 
            // txtEdadDoc
            // 
            this.txtEdadDoc.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdadDoc.Location = new System.Drawing.Point(179, 164);
            this.txtEdadDoc.Name = "txtEdadDoc";
            this.txtEdadDoc.Size = new System.Drawing.Size(83, 29);
            this.txtEdadDoc.TabIndex = 10;
            this.txtEdadDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdadDoc_KeyPress);
            // 
            // txtUniversidadDoc
            // 
            this.txtUniversidadDoc.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUniversidadDoc.Location = new System.Drawing.Point(179, 242);
            this.txtUniversidadDoc.Name = "txtUniversidadDoc";
            this.txtUniversidadDoc.Size = new System.Drawing.Size(259, 29);
            this.txtUniversidadDoc.TabIndex = 11;
            this.txtUniversidadDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUniversidadDoc_KeyPress);
            // 
            // lblEspDoctor
            // 
            this.lblEspDoctor.AutoSize = true;
            this.lblEspDoctor.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspDoctor.Location = new System.Drawing.Point(36, 208);
            this.lblEspDoctor.Name = "lblEspDoctor";
            this.lblEspDoctor.Size = new System.Drawing.Size(110, 22);
            this.lblEspDoctor.TabIndex = 12;
            this.lblEspDoctor.Text = "Especialidad";
            // 
            // btnGuardarDoctor
            // 
            this.btnGuardarDoctor.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarDoctor.Location = new System.Drawing.Point(93, 385);
            this.btnGuardarDoctor.Name = "btnGuardarDoctor";
            this.btnGuardarDoctor.Size = new System.Drawing.Size(96, 31);
            this.btnGuardarDoctor.TabIndex = 13;
            this.btnGuardarDoctor.Text = "Guardar";
            this.btnGuardarDoctor.UseVisualStyleBackColor = true;
            this.btnGuardarDoctor.Click += new System.EventHandler(this.btnGuardarDoctor_Click);
            // 
            // btnEliminarDoctor
            // 
            this.btnEliminarDoctor.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDoctor.Location = new System.Drawing.Point(417, 385);
            this.btnEliminarDoctor.Name = "btnEliminarDoctor";
            this.btnEliminarDoctor.Size = new System.Drawing.Size(96, 31);
            this.btnEliminarDoctor.TabIndex = 14;
            this.btnEliminarDoctor.Text = "Eliminar";
            this.btnEliminarDoctor.UseVisualStyleBackColor = true;
            this.btnEliminarDoctor.Click += new System.EventHandler(this.btnEliminarDoctor_Click);
            // 
            // btnModificarDoctor
            // 
            this.btnModificarDoctor.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarDoctor.Location = new System.Drawing.Point(249, 385);
            this.btnModificarDoctor.Name = "btnModificarDoctor";
            this.btnModificarDoctor.Size = new System.Drawing.Size(96, 31);
            this.btnModificarDoctor.TabIndex = 15;
            this.btnModificarDoctor.Text = "Modificar";
            this.btnModificarDoctor.UseVisualStyleBackColor = true;
            this.btnModificarDoctor.Click += new System.EventHandler(this.btnModificarDoctor_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(574, 385);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(144, 31);
            this.btnLimpiarCampos.TabIndex = 16;
            this.btnLimpiarCampos.Text = "Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // txtBuscarDoctor
            // 
            this.txtBuscarDoctor.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarDoctor.Location = new System.Drawing.Point(179, 324);
            this.txtBuscarDoctor.Name = "txtBuscarDoctor";
            this.txtBuscarDoctor.Size = new System.Drawing.Size(259, 29);
            this.txtBuscarDoctor.TabIndex = 18;
            this.txtBuscarDoctor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarDoctor_KeyPress);
            // 
            // dgvDoc
            // 
            this.dgvDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoc.Location = new System.Drawing.Point(93, 439);
            this.dgvDoc.Name = "dgvDoc";
            this.dgvDoc.Size = new System.Drawing.Size(625, 275);
            this.dgvDoc.TabIndex = 20;
            this.dgvDoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoc_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(530, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // lblBuscarDoc
            // 
            this.lblBuscarDoc.AutoSize = true;
            this.lblBuscarDoc.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarDoc.Location = new System.Drawing.Point(36, 327);
            this.lblBuscarDoc.Name = "lblBuscarDoc";
            this.lblBuscarDoc.Size = new System.Drawing.Size(63, 22);
            this.lblBuscarDoc.TabIndex = 23;
            this.lblBuscarDoc.Text = "Buscar";
            // 
            // lblClinica
            // 
            this.lblClinica.AutoSize = true;
            this.lblClinica.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClinica.Location = new System.Drawing.Point(36, 284);
            this.lblClinica.Name = "lblClinica";
            this.lblClinica.Size = new System.Drawing.Size(63, 22);
            this.lblClinica.TabIndex = 24;
            this.lblClinica.Text = "Clinica";
            // 
            // cmbClinica
            // 
            this.cmbClinica.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClinica.FormattingEnabled = true;
            this.cmbClinica.Location = new System.Drawing.Point(179, 284);
            this.cmbClinica.Name = "cmbClinica";
            this.cmbClinica.Size = new System.Drawing.Size(259, 29);
            this.cmbClinica.TabIndex = 25;
            // 
            // PantallaDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(812, 726);
            this.Controls.Add(this.cmbClinica);
            this.Controls.Add(this.lblClinica);
            this.Controls.Add(this.lblBuscarDoc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvDoc);
            this.Controls.Add(this.txtBuscarDoctor);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnModificarDoctor);
            this.Controls.Add(this.btnEliminarDoctor);
            this.Controls.Add(this.btnGuardarDoctor);
            this.Controls.Add(this.lblEspDoctor);
            this.Controls.Add(this.txtUniversidadDoc);
            this.Controls.Add(this.txtEdadDoc);
            this.Controls.Add(this.txtApellidoDoc);
            this.Controls.Add(this.txtNombreDoc);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.lblUniversidad);
            this.Controls.Add(this.lblEdDoctor);
            this.Controls.Add(this.lblApDoctor);
            this.Controls.Add(this.lblNomDoc);
            this.Controls.Add(this.lblTitulo);
            this.Name = "PantallaDoctor";
            this.Text = "PantallaDoctor";
            this.Load += new System.EventHandler(this.PantallaDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNomDoc;
        private System.Windows.Forms.Label lblApDoctor;
        private System.Windows.Forms.Label lblEdDoctor;
        private System.Windows.Forms.Label lblUniversidad;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.TextBox txtNombreDoc;
        private System.Windows.Forms.TextBox txtApellidoDoc;
        private System.Windows.Forms.TextBox txtEdadDoc;
        private System.Windows.Forms.TextBox txtUniversidadDoc;
        private System.Windows.Forms.Label lblEspDoctor;
        private System.Windows.Forms.Button btnGuardarDoctor;
        private System.Windows.Forms.Button btnEliminarDoctor;
        private System.Windows.Forms.Button btnModificarDoctor;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.TextBox txtBuscarDoctor;
        public System.Windows.Forms.DataGridView dgvDoc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBuscarDoc;
        private System.Windows.Forms.Label lblClinica;
        private System.Windows.Forms.ComboBox cmbClinica;
    }
}