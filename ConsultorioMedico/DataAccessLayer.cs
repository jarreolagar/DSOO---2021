using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    class DataAccessLayer
    {
        //Escribir una conexión a la base de datos
        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=consultorio;Data Source=THINKPAD-L470\\MSSQLSERVER02");

        public void loginUsuario(Usuario usuario)
        {

            try
            {
                //Abrir la conexión
                conn.Open();
                string query = @"
                                SELECT nombreUsuario, contrasenaUsuario
                                FROM usuarios
                                WHERE nombreUsuario=@nombreUsuario AND contrasenaUsuario=@contrasenaUsuario";

                SqlParameter nombreUsuario = new SqlParameter("@nombreUsuario", usuario.usuario);
                SqlParameter contrasenaUsuario = new SqlParameter("@contrasenaUsuario", usuario.contrasena);

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(nombreUsuario);
                command.Parameters.Add(contrasenaUsuario);

                SqlDataReader dr = command.ExecuteReader();

                if (dr.Read() == true)
                {
                    Login login = new Login();
                    login.Close();
                    PanelControl panel = new PanelControl();
                    panel.Show();
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

        }

        //Métodos

        public int guardarDoctor(string procedure, ArrayList parametros, ArrayList valores)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand(procedure, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            for (int datos = 0; datos < parametros.Count; datos++)
            {
                cmd.Parameters.AddWithValue(parametros[datos].ToString(), valores[datos]);
            }

            int resultado = cmd.ExecuteNonQuery();
            conn.Close();
            return resultado;

        }

        public int eliminarDoctor(string procedure, ArrayList parametros, ArrayList valores)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(procedure, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            for (int datos = 0; datos < parametros.Count; datos++)
            {
                cmd.Parameters.AddWithValue(parametros[datos].ToString(), valores[datos]);
            }

            int resultado = cmd.ExecuteNonQuery();
            conn.Close();
            return resultado;
        }

        public int buscarDoctor(string procedure, string parametros, string valores)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(procedure, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue(parametros, valores);

            int resultado = cmd.ExecuteNonQuery();
            conn.Close();
            return resultado;
        }

        public DataTable obtenerDoctores(string procedure, string parametros, string valores)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(procedure, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(parametros, valores);
            DataTable tableDoc = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(tableDoc);
            conn.Close();
            return tableDoc;
        }

        public DataTable obtenerDatosConsulta(string procedure, string parametros, string valores)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(procedure, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(parametros, valores);
            DataTable tableCon = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(tableCon);
            conn.Close();
            return tableCon;
        }

        public DataTable obtenerDatosMedicamento(string procedure, string parametros, string valores)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(procedure, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(parametros, valores);
            DataTable tableCon = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(tableCon);
            conn.Close();
            return tableCon;
        }

        public int actualizarDoctor(string procedure, ArrayList parametros, ArrayList valores)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(procedure, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            for(int datos = 0; datos < parametros.Count; datos++)
            {
                cmd.Parameters.AddWithValue(parametros[datos].ToString(), valores[datos]);
            }
            
            int resultado = cmd.ExecuteNonQuery();
            conn.Close();
            return resultado;
        }

        public int guardarPaciente(string procedure, ArrayList parametros, ArrayList valores)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(procedure, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            for(int datos = 0; datos < parametros.Count; datos++)
            {
                cmd.Parameters.AddWithValue(parametros[datos].ToString(), valores[datos]);
            }

            int resultado = cmd.ExecuteNonQuery();
            conn.Close();
            return resultado;
        }

        public int guardarCita(string procedure, ArrayList parametros, ArrayList valores)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(procedure, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            for (int datos = 0; datos < parametros.Count; datos++)
            {
                cmd.Parameters.AddWithValue(parametros[datos].ToString(), valores[datos]);
            }

            int resultado = cmd.ExecuteNonQuery();
            conn.Close();
            return resultado;
        }


    }
}
