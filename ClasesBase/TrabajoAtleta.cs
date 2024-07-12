using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBase
{
    public class TrabajoAtleta
    {
        public static void agregarAtleta(Atleta atleta)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "agregarAtleta";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@Dni", atleta.Atl_DNI);
            cmd.Parameters.AddWithValue("@Apellido", atleta.Atl_Apellido);
            cmd.Parameters.AddWithValue("@Nombre", atleta.Atl_Nombre);
            cmd.Parameters.AddWithValue("@Nacionalidad", atleta.Atl_Nacionalidad);
            cmd.Parameters.AddWithValue("@Entrenador", atleta.Atl_Entrenador);
            cmd.Parameters.AddWithValue("@Genero", atleta.Atl_Genero);
            cmd.Parameters.AddWithValue("@Altura", atleta.Atl_Altura);
            cmd.Parameters.AddWithValue("@Peso", atleta.Atl_Peso);
            cmd.Parameters.AddWithValue("@FechaNac", atleta.Atl_FechaNac);
            cmd.Parameters.AddWithValue("@Direccion", atleta.Atl_Direccion);
            cmd.Parameters.AddWithValue("@Email", atleta.Atl_Email);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public static Atleta obtenerAtletaById(Int32 id)
        {
            Atleta oAtleta = null;
            DataTable atletasTable = new DataTable();
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString))
            {
                SqlCommand cmd = new SqlCommand("obtenerAtletaById", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cnn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        oAtleta = new Atleta(reader.GetInt32(reader.GetOrdinal("Alt_ID")),
                            reader.GetString(reader.GetOrdinal("Alt_DNI")),
                            reader.GetString(reader.GetOrdinal("Alt_Apellido")),
                            reader.GetString(reader.GetOrdinal("Alt_Nombre")),
                            reader.GetString(reader.GetOrdinal("Alt_Nacionalidad")),
                            reader.GetString(reader.GetOrdinal("Alt_Entrenador")),
                            reader.GetString(reader.GetOrdinal("Alt_Genero"))[0],
                            reader.GetDouble(reader.GetOrdinal("Alt_Altura")),
                            reader.GetDouble(reader.GetOrdinal("Alt_Peso")),
                            reader.GetDateTime(reader.GetOrdinal("Alt_FechaNac")),
                            reader.GetString(reader.GetOrdinal("Alt_Direccion")),
                            reader.GetString(reader.GetOrdinal("Alt_Email"))
                            );
                    }
                }
                cnn.Close();
            }
            return oAtleta;
        }

        public static DataTable obtenerAtletasPorCompetencia(int compId)
        {
            DataTable atletas = new DataTable();

            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "obtenerAtletasPorCompetencia";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cnn;

                cmd.Parameters.AddWithValue("@CompID", compId);

                cnn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(atletas);
                atletas.Columns.Add("NombreCompleto", typeof(string), "Alt_Apellido + ', ' + Alt_Nombre ");

                cnn.Close();
            }

            return atletas;
        }

        public static void borrarAtleta(Int32 id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "borrarAtleta";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@id", id);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
        public static void ModificarAtleta(Atleta atleta)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "modificarAtleta";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", atleta.Atl_DNI);
            cmd.Parameters.AddWithValue("@apellido", atleta.Atl_Apellido);
            cmd.Parameters.AddWithValue("@nombre", atleta.Atl_Nombre);
            cmd.Parameters.AddWithValue("@nacionalidad", atleta.Atl_Nacionalidad);
            cmd.Parameters.AddWithValue("@entrenador", atleta.Atl_Entrenador);
            cmd.Parameters.AddWithValue("@genero", atleta.Atl_Genero);
            cmd.Parameters.AddWithValue("@altura", atleta.Atl_Altura);
            cmd.Parameters.AddWithValue("@peso", atleta.Atl_Peso);
            cmd.Parameters.AddWithValue("@fechaNac", atleta.Atl_FechaNac);
            cmd.Parameters.AddWithValue("@direccion", atleta.Atl_Direccion);
            cmd.Parameters.AddWithValue("@email", atleta.Atl_Entrenador);
            cmd.Parameters.AddWithValue("@id", atleta.Atl_ID);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static List<Atleta> obtenerAtletas()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "obtenerAtletas";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cnn.Open();
            List<Atleta> atletas = new List<Atleta>();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Atleta oAtleta = new Atleta(reader.GetInt32(reader.GetOrdinal("Alt_ID")),
                            reader.GetString(reader.GetOrdinal("Alt_DNI")),
                            reader.GetString(reader.GetOrdinal("Alt_Apellido")),
                            reader.GetString(reader.GetOrdinal("Alt_Nombre")),
                            reader.GetString(reader.GetOrdinal("Alt_Nacionalidad")),
                            reader.GetString(reader.GetOrdinal("Alt_Entrenador")),
                            reader.GetString(reader.GetOrdinal("Alt_Genero"))[0],
                            reader.GetDouble(reader.GetOrdinal("Alt_Altura")),
                            reader.GetDouble(reader.GetOrdinal("Alt_Peso")),
                            reader.GetDateTime(reader.GetOrdinal("Alt_FechaNac")),
                            reader.GetString(reader.GetOrdinal("Alt_Direccion")),
                            reader.GetString(reader.GetOrdinal("Alt_Email"))
                            );
                    atletas.Add(oAtleta);
                }
            }
            cnn.Close();
            return atletas;
        }

        public static List<Atleta> obtenerAtletasPorDNI()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "obtenerAtletasPorDNI";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cnn.Open();
            List<Atleta> atletas = new List<Atleta>();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Atleta oAtleta = new Atleta(reader.GetInt32(reader.GetOrdinal("Alt_ID")),
                            reader.GetString(reader.GetOrdinal("Alt_DNI")),
                            reader.GetString(reader.GetOrdinal("Alt_Apellido")),
                            reader.GetString(reader.GetOrdinal("Alt_Nombre")),
                            reader.GetString(reader.GetOrdinal("Alt_Nacionalidad")),
                            reader.GetString(reader.GetOrdinal("Alt_Entrenador")),
                            reader.GetString(reader.GetOrdinal("Alt_Genero"))[0],
                            reader.GetDouble(reader.GetOrdinal("Alt_Altura")),
                            reader.GetDouble(reader.GetOrdinal("Alt_Peso")),
                            reader.GetDateTime(reader.GetOrdinal("Alt_FechaNac")),
                            reader.GetString(reader.GetOrdinal("Alt_Direccion")),
                            reader.GetString(reader.GetOrdinal("Alt_Email"))
                            );
                    atletas.Add(oAtleta);
                }
            }
            cnn.Close();
            return atletas;
        }

        public static List<Atleta> obtenerAtletasPorApellido()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "obtenerAtletasPorDNI";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cnn.Open();
            List<Atleta> atletas = new List<Atleta>();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Atleta oAtleta = new Atleta(reader.GetInt32(reader.GetOrdinal("Alt_ID")),
                            reader.GetString(reader.GetOrdinal("Alt_DNI")),
                            reader.GetString(reader.GetOrdinal("Alt_Apellido")),
                            reader.GetString(reader.GetOrdinal("Alt_Nombre")),
                            reader.GetString(reader.GetOrdinal("Alt_Nacionalidad")),
                            reader.GetString(reader.GetOrdinal("Alt_Entrenador")),
                            reader.GetString(reader.GetOrdinal("Alt_Genero"))[0],
                            reader.GetDouble(reader.GetOrdinal("Alt_Altura")),
                            reader.GetDouble(reader.GetOrdinal("Alt_Peso")),
                            reader.GetDateTime(reader.GetOrdinal("Alt_FechaNac")),
                            reader.GetString(reader.GetOrdinal("Alt_Direccion")),
                            reader.GetString(reader.GetOrdinal("Alt_Email"))
                            );
                    atletas.Add(oAtleta);
                }
            }
            cnn.Close();
            return atletas;
        }
    }
}

