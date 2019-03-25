using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace TallerDBAlumnos
{
    public class Conexion
    {
        public Conexion()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "localhost";
                builder.UserID = "SA";
                builder.Password = "Hackman1896";
                builder.InitialCatalog = "master";

                Console.Write("Connecting to SQL Server ... ");
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    SqlCommand query = new SqlCommand(
                        "INSERT INTO Persona VALUES()",
                        connection);
                    Console.WriteLine("\nDone.");
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
