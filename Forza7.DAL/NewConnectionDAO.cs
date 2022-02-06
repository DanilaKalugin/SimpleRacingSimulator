using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;

namespace Kursach5.DAL
{
    public class NewConnectionDAO
    {

        public static string GetConnectionString()
        {
            var currentConnection = ConfigurationManager.AppSettings["CurrentConnectionString"];
            var connectionString = ConfigurationManager.ConnectionStrings[currentConnection].ConnectionString;
            return connectionString;
        }

        public void DeployDataBase(string ConnectionTitle, string serverName, bool IntegratedSecurity, out int result, out string message, string UserName = "", string UserPassword = "")
        {
            string newConnection = $"Data Source={serverName};" +
                                           $"Initial Catalog=master;" +
                                           $"Integrated Security={IntegratedSecurity};";
            if (!IntegratedSecurity)
            {
                newConnection += $"User ID={UserName};Password={UserPassword}";
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(newConnection))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("CREATE DATABASE [SimpleRacingSimulator]", connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                string DBConnection = $"Data Source={serverName};" +
                                               $"Initial Catalog=SimpleRacingSimulator;" +
                                               $"Integrated Security={IntegratedSecurity};";
                if (!IntegratedSecurity)
                {
                    DBConnection += $"User ID={UserName};Password={UserPassword}";
                }

                Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                configuration.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings(ConnectionTitle, DBConnection));
                configuration.Save();
                ConfigurationManager.RefreshSection("ConnectionStrings");
                configuration.AppSettings.Settings["CurrentConnectionString"].Value = ConnectionTitle;
                configuration.Save();
                ConfigurationManager.RefreshSection("AppSettings");
                DeployScript(DBConnection);
                result = 0;
                message = "The database deployment was successful";
            }
            catch (SqlException ex)
            {
                message = ex.Message;
                result = 1;
            }
        }

        private void DeployScript(string DBConnection)
        {
            List<string> scripts = Directory.GetFiles(@"Scripts\").OrderBy(str => str).ToList();
            using (SqlConnection conn = new SqlConnection(DBConnection))
            {
                conn.Open();
                foreach (string scriptFile in scripts)
                {
                    string script = File.ReadAllText(scriptFile);

                    using (SqlCommand command = new SqlCommand(script, conn))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                conn.Close();
            }
        }
    }
}