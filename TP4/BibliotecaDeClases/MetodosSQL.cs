using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDeClases;

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

        public static void GuardarUsuario(Usuario usuario)
        {
            try
            {
                connection.Open();
                command.Parameters.Clear();
                command.CommandText = $"INSERT INTO EMPLEADOS(legajoEmpleado,nombre,apellido,dni,nombreUsuario,password," +
                    $"esAdmin,salario,fechaIngreso,fechaNacimiento) VALUES(@legajo,@nombre,@apellido,@dni,@nombreUsuario," +
                    $"@password,@esAdmin,@salario,@fechaIngreso,@fechaNacimiento)";
                command.Parameters.AddWithValue("@legajo", usuario.Legajo);
                command.Parameters.AddWithValue("@nombre", usuario.Nombre);
                command.Parameters.AddWithValue("@apellido", usuario.Apellido);
                command.Parameters.AddWithValue("@dni", usuario.DNI);
                command.Parameters.AddWithValue("@nombreUsuario", usuario.NombreUsuario);
                command.Parameters.AddWithValue("@password", usuario.Password);
                command.Parameters.AddWithValue("@esAdmin", usuario.EsAdmin ? 1 : 0);
                command.Parameters.AddWithValue("@salario", usuario.Salario);
                command.Parameters.AddWithValue("@fechaIngreso", usuario.FechaIngreso);
                command.Parameters.AddWithValue("@fechaNacimiento", usuario.FechaNacimiento);
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void ModificarUsuario(Usuario usuario)
        {
            try
            {
                connection.Open();
                command.Parameters.Clear();
                command.CommandText = $"UPDATE EMPLEADOS SET nombre=@nombre, apellido=@apellido, dni=@dni, " +
                    $"nombreUsuario=@nombreUsuario,password=@password,esAdmin=@esAdmin,salario=@salario, " +
                    $"fechaIngreso=@fechaIngreso,fechaNacimiento=@fechaNacimiento " +
                    $"WHERE legajoEmpleado = {usuario.Legajo}";
                command.Parameters.AddWithValue("@nombre", usuario.Nombre);
                command.Parameters.AddWithValue("@apellido", usuario.Apellido);
                command.Parameters.AddWithValue("@dni", usuario.DNI);
                command.Parameters.AddWithValue("@nombreUsuario", usuario.NombreUsuario);
                command.Parameters.AddWithValue("@password", usuario.Password);
                command.Parameters.AddWithValue("@esAdmin", usuario.EsAdmin ? 1 : 0);
                command.Parameters.AddWithValue("@salario", usuario.Salario);
                command.Parameters.AddWithValue("@fechaIngreso", usuario.FechaIngreso);
                command.Parameters.AddWithValue("@fechaNacimiento", usuario.FechaNacimiento);
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }


        public static void GuardarListaUsuarios(List<Usuario> usuarios)
        {
            try
            {             
                connection.Open();
                command.CommandText = $"DELETE FROM EMPLEADOS";
                command.ExecuteNonQuery();
                foreach (Usuario usuario in Blockbuster.ListaDeEmpleados)
                {
                    command.Parameters.Clear();
                    command.CommandText = $"INSERT INTO EMPLEADOS(legajoEmpleado,nombre,apellido,dni,nombreUsuario,password," +
                        $"esAdmin,salario,fechaIngreso,fechaNacimiento) VALUES (@legajo,@nombre,@apellido,@dni,@nombreUsuario," +
                        $"@password,@esAdmin,@salario,@fechaIngreso,@fechaNacimiento)";
                    command.Parameters.AddWithValue("@legajo", usuario.Legajo);
                    command.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    command.Parameters.AddWithValue("@apellido", usuario.Apellido);
                    command.Parameters.AddWithValue("@dni", usuario.DNI);
                    command.Parameters.AddWithValue("@nombreUsuario", usuario.NombreUsuario);
                    command.Parameters.AddWithValue("@password", usuario.Password);
                    command.Parameters.AddWithValue("@esAdmin", usuario.EsAdmin ? 1 : 0);
                    command.Parameters.AddWithValue("@salario", usuario.Salario);
                    command.Parameters.AddWithValue("@fechaIngreso", usuario.FechaIngreso);
                    command.Parameters.AddWithValue("@fechaNacimiento", usuario.FechaNacimiento);
                    command.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<Usuario> LeerListaUsuarios()
        {
            List<Usuario> listaUsuariosAux = new List<Usuario>();
            try
            {
                connection.Open();
                command.CommandText = $"SELECT legajoEmpleado,nombre,apellido,dni,nombreUsuario,password,esAdmin,salario,fechaIngreso,fechaNacimiento" +
                    $" FROM EMPLEADOS ";
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        listaUsuariosAux.Add(new Usuario(Convert.ToInt32(dataReader["legajoEmpleado"]), dataReader["nombre"].ToString(), 
                            dataReader["apellido"].ToString(), Convert.ToInt32(dataReader["dni"]), dataReader["nombreUsuario"].ToString(),
                            dataReader["password"].ToString(), Convert.ToInt32(dataReader["esAdmin"])==0? true:false,Convert.ToDateTime(dataReader["fechaIngreso"]),
                            Convert.ToDateTime(dataReader["fechaNacimiento"]), Convert.ToDouble(dataReader["salario"])));
                    }
                }

                return listaUsuariosAux;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
