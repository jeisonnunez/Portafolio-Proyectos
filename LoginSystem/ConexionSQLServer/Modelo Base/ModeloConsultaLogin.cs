using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Entidades;

namespace Datos
{
    public class ModeloConsultaLogin:ModeloInicioSesion
    {
        public Tuple<object, string> ConsultaLogin(List<Usuarios> listaUsuarios)
        {
            string error = null;

            string usuario="";

            string clave = "";

            string sociedad = "";

            try
            {             
                foreach (Usuarios usuarios in listaUsuarios)
                {
                    usuario = usuarios.User_code;

                    clave = usuarios.Password;

                    sociedad = usuarios.Sociedad;
                }

                Connection = new SqlConnection(connectionString);

                Connection.Open();

                SqlCommand cmd = new SqlCommand(null, Connection);

                cmd = Connection.CreateCommand();

                cmd.CommandText = "LoginUser";

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@txtUsuario", usuario);

                cmd.Parameters.AddWithValue("@txtContrasena", hc.PassHash(clave));

                cmd.Parameters.AddWithValue("@txtSociedad", sociedad);

                var result = cmd.ExecuteScalar();

                Connection.Close();

                return Tuple.Create(result, error);

            }
            catch (Exception e)
            {       
                Connection.Close();              
              
                object result = null;

                return Tuple.Create(result, e.Message);
            }
        }

        public Tuple<string, string> GetNameSociety()
        {
            string sociedad=null;

            string error = null;

            try
            {

                Connection = new SqlConnection(connectionString);

                Connection.Open();

                SqlCommand cmde = new SqlCommand(null, Connection);

                cmde = Connection.CreateCommand();

                cmde.CommandText = "GetSociety";

                cmde.CommandType = CommandType.StoredProcedure;                

                SqlDataReader reader = cmde.ExecuteReader();

                if (reader.Read())
                {
                   sociedad = reader["CompnyName"].ToString();
                }

                Connection.Close();

                return Tuple.Create(sociedad, error);

            }
            catch (Exception e)
            {
                
                Connection.Close();

                return Tuple.Create(sociedad, e.Message);
            }
        }

        public Tuple<int, string> ObtenerIdUser(string username)
        {
            int usercode = 0;

            string error = null;

            try
            {

                Connection = new SqlConnection(connectionString);

                Connection.Open();

                SqlCommand cmde = new SqlCommand(null, Connection);

                cmde = Connection.CreateCommand();

                cmde.CommandText = "GetUserCode";

                cmde.CommandType = CommandType.StoredProcedure;

                cmde.Parameters.AddWithValue("@User", username);

                SqlDataReader reader = cmde.ExecuteReader();

                if (reader.Read())
                {
                    usercode = Int32.Parse(reader["USERID"].ToString());
                }

                Connection.Close();

                return Tuple.Create(usercode, error);

            }
            catch (Exception e)
            {                
                Connection.Close();

                return Tuple.Create(usercode, e.Message);
            }
        }
    }
}
