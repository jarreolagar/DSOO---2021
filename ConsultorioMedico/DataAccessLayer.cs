using System;
using System.Collections.Generic;
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
                if(dr.Read() == true)
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
    }
}
