﻿using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class PantallaMedicamentos : Form
    {
        private DataAccessLayer _dataAccessLayer;
        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=consultorio;Data Source=THINKPAD-L470\\MSSQLSERVER02");
        public PantallaMedicamentos()
        {
            InitializeComponent();
            _dataAccessLayer = new DataAccessLayer();
        }

        private void btnGuardarMed_Click(object sender, EventArgs e)
        {
            int habilitado = 1;

            bool flag = true;

            Medicamento medicamento = new Medicamento();

            medicamento.nombre = txtNombreMed.Text;
            medicamento.laboratorio = txtLaboratorio.Text;
            medicamento.administracion = txtAdministracion.Text;
            medicamento.especialidad = cmbEspecialidad.Text;
            medicamento.habilitado = habilitado;

            while (String.IsNullOrWhiteSpace(txtNombreMed.Text) || String.IsNullOrWhiteSpace(txtLaboratorio.Text) || String.IsNullOrWhiteSpace(txtAdministracion.Text) || String.IsNullOrWhiteSpace(cmbEspecialidad.Text) || String.IsNullOrWhiteSpace(cmbEspecialidad.Text))
            {
                MessageBox.Show("Llena todos los campos");
                flag = false;
                break;
            }
            if (flag == false)
            {
                return;
            }
            else
            {
                int resultado = _dataAccessLayer.guardarDoctor(
                    "insertarMedicamento",
                    new ArrayList { "@nombreMedicamento", "@laboratorio", "@administracion", "@habilitado", "@especialidad" },
                    new ArrayList { medicamento.nombre, medicamento.laboratorio, medicamento.administracion, medicamento.habilitado, medicamento.especialidad });
                if (resultado == 1)
                {
                    MessageBox.Show("Registro insertado");
                    llenarTablaMedicamentos();
                }

            }

        }

        private void llenarTablaMedicamentos()
        {
            conn.Open();
            string query = @"SELECT idMedicamento, nombreMedicamento, laboratorio, administracion, especialidad
                             FROM medicamentos
                             WHERE mhabilitado=1";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();

            sda.Fill(ds, "medicamentos");
            dataGridMed.DataSource = ds.Tables["medicamentos"].DefaultView;
            conn.Close();
        }

        private void PantallaMedicamentos_Load(object sender, EventArgs e)
        {
            llenarTablaMedicamentos();
        }

        private void dataGridMed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarCamposMedicina();
        }

        private void llenarCamposMedicina()
        {
            Medicamento medicamento = new Medicamento()
;
            medicamento.idMedicamento = dataGridMed.CurrentRow.Cells[0].Value.ToString();
            DataTable mostrarInfo = _dataAccessLayer.obtenerDatosMedicamento("obtenerMedicamento", "@idMedicamento", medicamento.idMedicamento);
            txtNombreMed.Text = mostrarInfo.Rows[0][0].ToString();
            txtLaboratorio.Text = mostrarInfo.Rows[0][1].ToString();
            txtAdministracion.Text = mostrarInfo.Rows[0][2].ToString();
            cmbEspecialidad.Text = mostrarInfo.Rows[0][3].ToString();
        }

        private void btnModificarMed_Click(object sender, EventArgs e)
        {
            Medicamento medicamento = new Medicamento();
            medicamento.nombre = txtNombreMed.Text;
            medicamento.laboratorio = txtLaboratorio.Text;
            medicamento.administracion = txtAdministracion.Text;
            medicamento.especialidad = cmbEspecialidad.Text;

            medicamento.idMedicamento = dataGridMed.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Desea modificar?", "AVISO", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            {
                int resultado = _dataAccessLayer.actualizarDoctor(
                    "modificarMedicamento",
                    new ArrayList { "@idMedicamento", "@nombreMedicamento", "@laboratorio", "@administracion", "@especialidad" },
                    new ArrayList { medicamento.idMedicamento, medicamento.nombre, medicamento.laboratorio, medicamento.administracion, medicamento.especialidad });
                if (resultado == 1)
                {
                    MessageBox.Show("Registro actualizado");
                    llenarTablaMedicamentos();
                }
            }

        }

        private void btnEliminarMed_Click(object sender, EventArgs e)
        {
            int inhabilitar = 0;
            Medicamento medicamento = new Medicamento();

            medicamento.idMedicamento = dataGridMed.CurrentRow.Cells[0].Value.ToString();
            medicamento.habilitado = inhabilitar;
            if (MessageBox.Show("¿Desea Eliminar?", "AVISO", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            {

                int resultado = _dataAccessLayer.eliminarDoctor("eliminarMedicamento", new ArrayList { "@idMedicamento", "@habilitado" }, new ArrayList { medicamento.idMedicamento, medicamento.habilitado });
                if (resultado == 1)
                {
                    MessageBox.Show("Se eliminó correctamente");
                    llenarTablaMedicamentos();
                }
                else
                {
                    MessageBox.Show("No se eliminó");
                }
            }
        }

        private void btnLimpiarMed_Click(object sender, EventArgs e)
        {
            txtNombreMed.Clear();
            txtLaboratorio.Clear();
            txtAdministracion.Clear();
            cmbEspecialidad.ResetText();
        }

        private void filtrar(object sender, EventArgs e)
        {
            string nombre = txtBuscar.Text;
            _dataAccessLayer.buscarDoctor("buscarMed", "buscar", nombre, dataGridMed);
        }
    }
}