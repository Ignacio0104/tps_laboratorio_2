using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class MetodosSQL
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static MetodosSQL()
        {
            connectionString = @"Data Source=.;Initial Catalog=EMPLEADOSBLOCKBUSTER_DB;Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }
    }
}
