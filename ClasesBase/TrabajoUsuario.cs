using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Runtime.InteropServices;

namespace ClasesBase
{
    public class TrabajoUsuario
    {
        public static bool comprobarDisponibilidadNombre(string nombreUsuario)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "ComprobarDisponibilidadUsuario";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter param;
            param = new SqlParameter("@Usuario", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = nombreUsuario;
            cmd.Parameters.Add(param);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt.Rows.Count == 0;
        }

        /*
        public static bool login(string nombreUsuario, string passwrd)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"SELECT * FROM Usuario WHERE Usu_NombreUsuario='{nombreUsuario}' AND Usu_Contraseña='{passwrd}'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt.Rows.Count > 0;
        }
        */

        public static DataTable login(string nombreUsuario, string password)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Login";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param1 = new SqlParameter("@Usuario", SqlDbType.VarChar);
            SqlParameter param2 = new SqlParameter("@Contrasenia", SqlDbType.VarChar);
            param1.Direction = ParameterDirection.Input;
            param2.Direction = ParameterDirection.Input;
            param1.Value = nombreUsuario;
            param2.Value = password;

            cmd.Parameters.Add(param1);
            cmd.Parameters.Add(param2); 

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable list_roles()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ListarRoles";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void insert_users(Usuario user)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "CrearUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param1 = new SqlParameter("@Usuario", SqlDbType.VarChar);
            SqlParameter param2 = new SqlParameter("@Password", SqlDbType.VarChar);
            SqlParameter param3 = new SqlParameter("@NombreCompleto", SqlDbType.VarChar);
            SqlParameter param4 = new SqlParameter("@Rol", SqlDbType.Int);
            param1.Direction = ParameterDirection.Input;
            param2.Direction = ParameterDirection.Input;
            param3.Direction = ParameterDirection.Input;
            param4.Direction = ParameterDirection.Input;
            param1.Value = user.Usu_NombreUsuario;
            param2.Value = user.Usu_Contrasenia;
            param3.Value = user.Usu_ApellidoNombre;
            param4.Value = user.Rol_Codigo;

            cmd.Parameters.Add(param1);
            cmd.Parameters.Add(param2);
            cmd.Parameters.Add(param3);
            cmd.Parameters.Add(param4);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public static void update_user(Usuario user)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ModificarUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param1 = new SqlParameter("@Usuario", SqlDbType.VarChar);
            SqlParameter param2 = new SqlParameter("@Password", SqlDbType.VarChar);
            SqlParameter param3 = new SqlParameter("@NombreCompleto", SqlDbType.VarChar);
            SqlParameter param4 = new SqlParameter("@Rol", SqlDbType.Int);
            SqlParameter param5 = new SqlParameter("@Id", SqlDbType.Int);
            param1.Direction = ParameterDirection.Input;
            param2.Direction = ParameterDirection.Input;
            param3.Direction = ParameterDirection.Input;
            param4.Direction = ParameterDirection.Input;
            param5.Direction = ParameterDirection.Input;
            param1.Value = user.Usu_NombreUsuario;
            param2.Value = user.Usu_Contrasenia;
            param3.Value = user.Usu_ApellidoNombre;
            param4.Value = user.Rol_Codigo;
            param5.Value = user.Usu_ID;

            cmd.Parameters.Add(param1);
            cmd.Parameters.Add(param2);
            cmd.Parameters.Add(param3);
            cmd.Parameters.Add(param4);
            cmd.Parameters.Add(param5);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public static void delete_user(string nombreUsuario)
        {
           SqlConnection cnn = new SqlConnection (ClasesBase.Properties.Settings.Default.comdepConnectionString);
           SqlCommand cmd = new SqlCommand();
           cmd.CommandText = "EliminarUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param;
            param = new SqlParameter("@Usuario", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = nombreUsuario;
            cmd.Parameters.Add(param);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static Usuario GetUserById(int id)
        {
            Usuario user = null;
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "ObtenerUsuarioById";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cnn;

                SqlParameter param;
                param = new SqlParameter("@Id", SqlDbType.Int);
                param.Direction = ParameterDirection.Input;
                param.Value = id;
                cmd.Parameters.Add(param);

                cnn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new Usuario
                        {
                            Usu_ID = reader.GetInt32(reader.GetOrdinal("Usu_ID")),
                            Usu_NombreUsuario = reader.GetString(reader.GetOrdinal("Usu_NombreUsuario")),
                            Usu_ApellidoNombre = reader.GetString(reader.GetOrdinal("Usu_ApellidoNombre")),
                            Usu_Contrasenia = reader.GetString(reader.GetOrdinal("Usu_Contraseña")),
                            Rol_Codigo = reader.GetInt32(reader.GetOrdinal("Rol_Codigo"))
                        };
                    }
                }
            }
            return user;
        }

        public static DataTable GetUsersByFullname(string keyword)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "ObtenerUsuariosByNombre";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cnn;

                SqlParameter param;
                param = new SqlParameter("@Keyword", SqlDbType.VarChar);
                param.Direction = ParameterDirection.Input;
                param.Value = $"%{keyword}%";
                cmd.Parameters.Add(param);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable usuarios = new DataTable();
                    da.Fill(usuarios);
                    return usuarios;
                }
            }
        }
        public static DataTable list_usuarios()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ObtenerUsuarios";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

    }
}
