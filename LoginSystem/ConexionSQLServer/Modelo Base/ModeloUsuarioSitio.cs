using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelo_Base
{
    public class ModeloUsuarioSitio
    {
        private SqlConnection sqlConnection;

        public SqlConnection SqlConnection { get => sqlConnection; set => sqlConnection = value; }

        private string server;
        public string Server { get => server; set => server = value; }

        private string connectionString;
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public Tuple<bool, string> VerifyUserAdministratorSQLServer(string user, string password)
        {
            bool sw = false;

            string error = null;

            try
            {
                Server = Environment.MachineName; //verificar con instancia sql server

                ConnectionString = String.Format("Server={0}; User ID={1}; Password={2}", Server, user, password);

                SqlServerConnectionString(connectionString);

                if (IsConnection == true)
                {
                    sw = true;
                }
                else
                {
                    sw = false;
                }

                return Tuple.Create(sw, error);

            }
            catch (Exception e)
            {
                return Tuple.Create(sw, e.Message);
            }


        }

        private void SqlServerConnectionString(string connectionString)
        {
            SqlConnection = new SqlConnection(connectionString);
        }

        public bool IsConnection
        {
            get
            {
                if (SqlConnection.State == System.Data.ConnectionState.Closed)
                {
                    SqlConnection.Open();
                }

                return true;
            }
        }

        
    }
}
