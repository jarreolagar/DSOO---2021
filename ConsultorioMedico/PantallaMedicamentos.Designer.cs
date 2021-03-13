namespace ConsultorioMedico
{
    partial class PantallaMedicamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaMedicamentos));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.txtNombreMed = new System.Windows.Forms.TextBox();
            this.txtAdministracion = new System.Windows.Forms.TextBox();
            this.txtLaboratorio = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dataGridMed = new System.Windows.Forms.DataGridView();
            this.btnGuardarMed = new System.Windows.Forms.Button();
            this.btnModificarMed = new System.Windows.Forms.Button();
            this.btnEliminarMed = new System.Windows.Forms.Button();
            this.btnLimpiarMed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMed)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(442, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Laboratorio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Administración";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Especialidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Buscar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(111, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Medicamentos";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Items.AddRange(new object[] {
            "Psiquiatría",
            "Cardiología",
            "Neumología",
            "Pediatría",
            "Oncología",
            "Oftalmología",
            "Dermatología",
            "Anestesiología",
            "Endocrinología",
            "Gastroenterología",
            "Geriatría",
            "Medicina Interna",
            "Nefrología",
            "Reumatología",
            "Neurología",
            "Urología"});
            this.cmbEspecialidad.Location = new System.Drawing.Point(165, 213);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(231, 28);
            this.cmbEspecialidad.TabIndex = 7;
            // 
            // txtNombreMed
            // 
            this.txtNombreMed.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMed.Location = new System.Drawing.Point(165, 77);
            this.txtNombreMed.Name = "txtNombreMed";
            this.txtNombreMed.Size = new System.Drawing.Size(231, 27);
            this.txtNombreMed.TabIndex = 8;
            // 
            // txtAdministracion
            // 
            this.txtAdministracion.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdministracion.Location = new System.Drawing.Point(165, 167);
            this.txtAdministracion.Name = "txtAdministracion";
            this.txtAdministracion.Size = new System.Drawing.Size(100, 27);
            this.txtAdministracion.TabIndex = 9;
            // 
            // txtLaboratorio
            // 
            this.txtLaboratorio.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLaboratorio.Location = new System.Drawing.Point(165, 123);
            this.txtLaboratorio.Name = "txtLaboratorio";
            this.txtLaboratorio.Size = new System.Drawing.Size(231, 27);
            this.txtLaboratorio.TabIndex = 10;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(165, 265);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(231, 27);
            this.txtBuscar.TabIndex = 11;
            // 
            // dataGridMed
            // 
            this.dataGridMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMed.Location = new System.Drawing.Point(29, 387);
            this.dataGridMed.Name = "dataGridMed";
            this.dataGridMed.Size = new System.Drawing.Size(615, 150);
            this.dataGridMed.TabIndex = 12;
            this.dataGridMed.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMed_CellClick);
            // 
            // btnGuardarMed
            // 
            this.btnGuardarMed.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarMed.Location = new System.Drawing.Point(29, 326);
            this.btnGuardarMed.Name = "btnGuardarMed";
            this.btnGuardarMed.Size = new System.Drawing.Size(92, 33);
            this.btnGuardarMed.TabIndex = 13;
            this.btnGuardarMed.Text = "Guardar";
            this.btnGuardarMed.UseVisualStyleBackColor = true;
            this.btnGuardarMed.Click += new System.EventHandler(this.btnGuardarMed_Click);
            // 
            // btnModificarMed
            // 
            this.btnModificarMed.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMed.Location = new System.Drawing.Point(192, 326);
            this.btnModificarMed.Name = "btnModificarMed";
            this.btnModificarMed.Size = new System.Drawing.Size(91, 33);
            this.btnModificarMed.TabIndex = 14;
            this.btnModificarMed.Text = "Modificar";
            this.btnModificarMed.UseVisualStyleBackColor = true;
            this.btnModificarMed.Click += new System.EventHandler(this.btnModificarMed_Click);
            // 
            // btnEliminarMed
            // 
            this.btnEliminarMed.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMed.Location = new System.Drawing.Point(350, 326);
            this.btnEliminarMed.Name = "btnEliminarMed";
            this.btnEliminarMed.Size = new System.Drawing.Size(91, 33);
            this.btnEliminarMed.TabIndex = 15;
            this.btnEliminarMed.Text = "Eliminar";
            this.btnEliminarMed.UseVisualStyleBackColor = true;
            this.btnEliminarMed.Click += new System.EventHandler(this.btnEliminarMed_Click);
            // 
            // btnLimpiarMed
            // 
            this.btnLimpiarMed.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarMed.Location = new System.Drawing.Point(501, 326);
            this.btnLimpiarMed.Name = "btnLimpiarMed";
            this.btnLimpiarMed.Size = new System.Drawing.Size(143, 33);
            this.btnLimpiarMed.TabIndex = 16;
            this.btnLimpiarMed.Text = "Limpiar campos";
            this.btnLimpiarMed.UseVisualStyleBackColor = true;
            this.btnLimpiarMed.Click += new System.EventHandler(this.btnLimpiarMed_Click);
            // 
            // PantallaMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(677, 558);
            this.Controls.Add(this.btnLimpiarMed);
            this.Controls.Add(this.btnEliminarMed);
            this.Controls.Add(this.btnModificarMed);
            this.Controls.Add(this.btnGuardarMed);
            this.Controls.Add(this.dataGridMed);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtLaboratorio);
            this.Controls.Add(this.txtAdministracion);
            this.Controls.Add(this.txtNombreMed);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PantallaMedicamentos";
            this.Text = "PantallaMedicamentos";
            this.Load += new System.EventHandler(this.PantallaMedicamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.TextBox txtNombreMed;
        private System.Windows.Forms.TextBox txtAdministracion;
        private System.Windows.Forms.TextBox txtLaboratorio;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dataGridMed;
        private System.Windows.Forms.Button btnGuardarMed;
        private System.Windows.Forms.Button btnModificarMed;
        private System.Windows.Forms.Button btnEliminarMed;
        private System.Windows.Forms.Button btnLimpiarMed;
    }
}