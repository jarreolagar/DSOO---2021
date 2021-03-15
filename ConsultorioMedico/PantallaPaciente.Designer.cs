namespace ConsultorioMedico
{
    partial class PantallaPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPaciente));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.lblApellidoPaciente = new System.Windows.Forms.Label();
            this.lblEdadPaciente = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblEnfermedad = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblDoc = new System.Windows.Forms.Label();
            this.txtNombrePac = new System.Windows.Forms.TextBox();
            this.txtApellidoPac = new System.Windows.Forms.TextBox();
            this.txtEdadPac = new System.Windows.Forms.TextBox();
            this.txtPesoPac = new System.Windows.Forms.TextBox();
            this.txtAlturaPac = new System.Windows.Forms.TextBox();
            this.txtEnfermedad = new System.Windows.Forms.TextBox();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.btnGuardarPac = new System.Windows.Forms.Button();
            this.btnModificarPac = new System.Windows.Forms.Button();
            this.btnEliminarPac = new System.Windows.Forms.Button();
            this.btnLimpiarCamposPac = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarPaciente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(73, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(312, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Administración de Pacientes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(413, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePaciente.Location = new System.Drawing.Point(22, 65);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(78, 22);
            this.lblNombrePaciente.TabIndex = 2;
            this.lblNombrePaciente.Text = "Nombre";
            // 
            // lblApellidoPaciente
            // 
            this.lblApellidoPaciente.AutoSize = true;
            this.lblApellidoPaciente.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoPaciente.Location = new System.Drawing.Point(21, 98);
            this.lblApellidoPaciente.Name = "lblApellidoPaciente";
            this.lblApellidoPaciente.Size = new System.Drawing.Size(79, 22);
            this.lblApellidoPaciente.TabIndex = 3;
            this.lblApellidoPaciente.Text = "Apellido";
            // 
            // lblEdadPaciente
            // 
            this.lblEdadPaciente.AutoSize = true;
            this.lblEdadPaciente.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdadPaciente.Location = new System.Drawing.Point(22, 175);
            this.lblEdadPaciente.Name = "lblEdadPaciente";
            this.lblEdadPaciente.Size = new System.Drawing.Size(50, 22);
            this.lblEdadPaciente.TabIndex = 4;
            this.lblEdadPaciente.Text = "Edad";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(22, 207);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(49, 22);
            this.lblPeso.TabIndex = 5;
            this.lblPeso.Text = "Peso";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(22, 239);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(60, 22);
            this.lblAltura.TabIndex = 6;
            this.lblAltura.Text = "Altura";
            // 
            // lblEnfermedad
            // 
            this.lblEnfermedad.AutoSize = true;
            this.lblEnfermedad.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnfermedad.Location = new System.Drawing.Point(22, 311);
            this.lblEnfermedad.Name = "lblEnfermedad";
            this.lblEnfermedad.Size = new System.Drawing.Size(107, 22);
            this.lblEnfermedad.TabIndex = 7;
            this.lblEnfermedad.Text = "Enfermedad";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(136, 274);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 29);
            this.comboBox1.TabIndex = 8;
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoc.Location = new System.Drawing.Point(22, 273);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(67, 22);
            this.lblDoc.TabIndex = 9;
            this.lblDoc.Text = "Doctor";
            // 
            // txtNombrePac
            // 
            this.txtNombrePac.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePac.Location = new System.Drawing.Point(136, 67);
            this.txtNombrePac.Name = "txtNombrePac";
            this.txtNombrePac.Size = new System.Drawing.Size(220, 29);
            this.txtNombrePac.TabIndex = 10;
            // 
            // txtApellidoPac
            // 
            this.txtApellidoPac.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoPac.Location = new System.Drawing.Point(136, 99);
            this.txtApellidoPac.Name = "txtApellidoPac";
            this.txtApellidoPac.Size = new System.Drawing.Size(220, 29);
            this.txtApellidoPac.TabIndex = 11;
            // 
            // txtEdadPac
            // 
            this.txtEdadPac.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdadPac.Location = new System.Drawing.Point(136, 176);
            this.txtEdadPac.Name = "txtEdadPac";
            this.txtEdadPac.Size = new System.Drawing.Size(61, 29);
            this.txtEdadPac.TabIndex = 12;
            // 
            // txtPesoPac
            // 
            this.txtPesoPac.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoPac.Location = new System.Drawing.Point(136, 208);
            this.txtPesoPac.Name = "txtPesoPac";
            this.txtPesoPac.Size = new System.Drawing.Size(61, 29);
            this.txtPesoPac.TabIndex = 13;
            // 
            // txtAlturaPac
            // 
            this.txtAlturaPac.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlturaPac.Location = new System.Drawing.Point(136, 241);
            this.txtAlturaPac.Name = "txtAlturaPac";
            this.txtAlturaPac.Size = new System.Drawing.Size(61, 29);
            this.txtAlturaPac.TabIndex = 14;
            // 
            // txtEnfermedad
            // 
            this.txtEnfermedad.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnfermedad.Location = new System.Drawing.Point(136, 312);
            this.txtEnfermedad.MinimumSize = new System.Drawing.Size(50, 90);
            this.txtEnfermedad.Multiline = true;
            this.txtEnfermedad.Name = "txtEnfermedad";
            this.txtEnfermedad.Size = new System.Drawing.Size(341, 90);
            this.txtEnfermedad.TabIndex = 15;
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Location = new System.Drawing.Point(25, 528);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.Size = new System.Drawing.Size(631, 150);
            this.dgvPacientes.TabIndex = 16;
            this.dgvPacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacientes_CellClick);
            // 
            // btnGuardarPac
            // 
            this.btnGuardarPac.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPac.Location = new System.Drawing.Point(25, 479);
            this.btnGuardarPac.Name = "btnGuardarPac";
            this.btnGuardarPac.Size = new System.Drawing.Size(96, 31);
            this.btnGuardarPac.TabIndex = 17;
            this.btnGuardarPac.Text = "Guardar";
            this.btnGuardarPac.UseVisualStyleBackColor = true;
            this.btnGuardarPac.Click += new System.EventHandler(this.btnGuardarPac_Click);
            // 
            // btnModificarPac
            // 
            this.btnModificarPac.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPac.Location = new System.Drawing.Point(184, 479);
            this.btnModificarPac.Name = "btnModificarPac";
            this.btnModificarPac.Size = new System.Drawing.Size(96, 31);
            this.btnModificarPac.TabIndex = 19;
            this.btnModificarPac.Text = "Modificar";
            this.btnModificarPac.UseVisualStyleBackColor = true;
            this.btnModificarPac.Click += new System.EventHandler(this.btnModificarPac_Click);
            // 
            // btnEliminarPac
            // 
            this.btnEliminarPac.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPac.Location = new System.Drawing.Point(356, 479);
            this.btnEliminarPac.Name = "btnEliminarPac";
            this.btnEliminarPac.Size = new System.Drawing.Size(96, 31);
            this.btnEliminarPac.TabIndex = 20;
            this.btnEliminarPac.Text = "Eliminar";
            this.btnEliminarPac.UseVisualStyleBackColor = true;
            this.btnEliminarPac.Click += new System.EventHandler(this.btnEliminarPac_Click);
            // 
            // btnLimpiarCamposPac
            // 
            this.btnLimpiarCamposPac.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCamposPac.Location = new System.Drawing.Point(516, 479);
            this.btnLimpiarCamposPac.Name = "btnLimpiarCamposPac";
            this.btnLimpiarCamposPac.Size = new System.Drawing.Size(140, 31);
            this.btnLimpiarCamposPac.TabIndex = 21;
            this.btnLimpiarCamposPac.Text = "Limpiar campos";
            this.btnLimpiarCamposPac.UseVisualStyleBackColor = true;
            this.btnLimpiarCamposPac.Click += new System.EventHandler(this.btnLimpiarCamposPac_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Kg";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(22, 139);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(66, 22);
            this.lblCorreo.TabIndex = 23;
            this.lblCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(136, 136);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(220, 29);
            this.txtCorreo.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Buscar";
            // 
            // txtBuscarPaciente
            // 
            this.txtBuscarPaciente.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPaciente.Location = new System.Drawing.Point(136, 417);
            this.txtBuscarPaciente.Name = "txtBuscarPaciente";
            this.txtBuscarPaciente.Size = new System.Drawing.Size(220, 29);
            this.txtBuscarPaciente.TabIndex = 26;
            this.txtBuscarPaciente.TextChanged += new System.EventHandler(this.filtrado);
            // 
            // PantallaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(679, 690);
            this.Controls.Add(this.txtBuscarPaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpiarCamposPac);
            this.Controls.Add(this.btnEliminarPac);
            this.Controls.Add(this.btnModificarPac);
            this.Controls.Add(this.btnGuardarPac);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.txtEnfermedad);
            this.Controls.Add(this.txtAlturaPac);
            this.Controls.Add(this.txtPesoPac);
            this.Controls.Add(this.txtEdadPac);
            this.Controls.Add(this.txtApellidoPac);
            this.Controls.Add(this.txtNombrePac);
            this.Controls.Add(this.lblDoc);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblEnfermedad);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblEdadPaciente);
            this.Controls.Add(this.lblApellidoPaciente);
            this.Controls.Add(this.lblNombrePaciente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "PantallaPaciente";
            this.Text = "PantallaPaciente";
            this.Load += new System.EventHandler(this.PantallaPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.Label lblApellidoPaciente;
        private System.Windows.Forms.Label lblEdadPaciente;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblEnfermedad;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.TextBox txtNombrePac;
        private System.Windows.Forms.TextBox txtApellidoPac;
        private System.Windows.Forms.TextBox txtEdadPac;
        private System.Windows.Forms.TextBox txtPesoPac;
        private System.Windows.Forms.TextBox txtAlturaPac;
        private System.Windows.Forms.TextBox txtEnfermedad;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.Button btnGuardarPac;
        private System.Windows.Forms.Button btnModificarPac;
        private System.Windows.Forms.Button btnEliminarPac;
        private System.Windows.Forms.Button btnLimpiarCamposPac;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarPaciente;
    }
}