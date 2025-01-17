﻿using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class PantallaConsultas : Form
    {
        private DataAccessLayer _dataAccessLayer;
        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=consultorio;Data Source=THINKPAD-L470\\MSSQLSERVER02");
        public PantallaConsultas()
        {
            InitializeComponent();
            _dataAccessLayer = new DataAccessLayer();
        }

        private void llenarTablaConsultas()
        {
            conn.Open();
            string query = @"SELECT pac.idPaciente, pac.nombrePaciente, pac.apellidoPaciente, pac.correo, doc.nombreDoctor, c.nombreClinica
                             FROM pacientes as pac
                             INNER JOIN doctores as doc ON doc.idDoctor=pac.idDoctor
                             INNER JOIN clinica as c ON c.idClinica=doc.idClinica
                             WHERE pac.phabilitado=1 AND doc.dhabilitado=1";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();

            sda.Fill(ds, "pacientes");
            dataGridView1.DataSource = ds.Tables["pacientes"].DefaultView;
            conn.Close();
        }

        private void PantallaConsultas_Load(object sender, System.EventArgs e)
        {
            llenarTablaConsultas();
            llenarTablaAgendadas();
        }

        private void llenarCamposPaciente()
        {
            Paciente paciente = new Paciente();

            paciente.idPaciente = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DataTable mostrarInfo = _dataAccessLayer.obtenerDatosConsulta("obtenerDatoConsulta", "@idPaciente", paciente.idPaciente);
            txtNombre.Text = mostrarInfo.Rows[0][0].ToString();
            txtApellido.Text = mostrarInfo.Rows[0][1].ToString();
            txtCorreo.Text = mostrarInfo.Rows[0][2].ToString();
            txtDoctor.Text = mostrarInfo.Rows[0][3].ToString();
            txtClinica.Text = mostrarInfo.Rows[0][4].ToString();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarCamposPaciente();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();
            //Para quien va dirigido el correo
            mmsg.To.Add(txtCorreo.Text);
            //Asunto del correo
            mmsg.Subject = "Cita agendada";
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
            mmsg.Bcc.Add("jmarreola.gar@outlook.com");
            mmsg.Body = @"<h2>Tu cita ha sido agendada, " + txtNombre.Text + "</h2><p>Paciente: " + txtNombre.Text + " " + txtApellido.Text +"</p><p>Doctor: " + txtDoctor.Text +"</p><p>Clínica: " + txtClinica.Text + "</p><p>Fecha: "+ dateTimePicker1.Value.ToString("dd/MM/yyyy") + "</p><p>Hora: " + dateTimePicker2.Value.ToString("HH:mm") + "</p>"; 
                                           
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true;
            mmsg.From = new System.Net.Mail.MailAddress("especialidadesguadalajara@gmail.com");

            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential("especialidadesguadalajara@gmail.com", "especialidades.");

            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com";
            
            try
            {
                cliente.Send(mmsg);
                MessageBox.Show("Cita Agendada");

                Consulta consulta = new Consulta();
                consulta.nombre = txtNombre.Text;
                consulta.apellido = txtApellido.Text;
                consulta.clinica = txtClinica.Text;
                consulta.fecha = txtClinica.Text;
                consulta.fecha = dateTimePicker1.Value.ToString("ddMMyyyy");
                consulta.hora = dateTimePicker2.Value.ToString("HH:mm");
                consulta.doctor = txtDoctor.Text;

                int resultado = _dataAccessLayer.guardarCita(
                    "citaAgendada",
                    new ArrayList { "@nombre", "@apellido", "@clinica", "@fecha", "@hora", "@doctor"},
                    new ArrayList { consulta.nombre, consulta.apellido, consulta.clinica, consulta.fecha, consulta.hora, consulta.doctor });
                if (resultado == 1)
                {
                    llenarTablaAgendadas();
                    limpiarCampos();
                }
            }
            catch
            {
                MessageBox.Show("Error al enviar");
            }
        }

        private void llenarTablaAgendadas()
        {
            conn.Open();
            string query = @"SELECT *
                             FROM consulta";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();

            sda.Fill(ds, "consulta");
            dataGridView2.DataSource = ds.Tables["consulta"].DefaultView;
            conn.Close();
        }

        private void limpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtClinica.Clear();
            txtCorreo.Clear();
            txtDoctor.Clear();
        }

    
    }
}
