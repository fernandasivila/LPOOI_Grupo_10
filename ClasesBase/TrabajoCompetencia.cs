using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ClasesBase
{
    public class TrabajoCompetencia
    {
        private static string connectionString = ClasesBase.Properties.Settings.Default.comdepConnectionString;

        public static void AgregarComptencia(
            Competencia competencia)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "agregarCompetencia";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cnn;
                cmd.Parameters.AddWithValue("@Nombre", competencia.Com_Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", competencia.Com_Descripcion);
                cmd.Parameters.AddWithValue("@FechaInicio", competencia.Com_FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin", competencia.Com_FechaFin);
                cmd.Parameters.AddWithValue("@Estado", competencia.Com_Estado);
                cmd.Parameters.AddWithValue("@Organizador", competencia.Com_Organizador);
                cmd.Parameters.AddWithValue("@Ubicacion", competencia.Com_Ubicacion);
                cmd.Parameters.AddWithValue("@Sponsors", competencia.Com_Sponsors);
                cmd.Parameters.AddWithValue("@Categoria", competencia.Cat_ID);
                cmd.Parameters.AddWithValue("@Disciplina", competencia.Dis_ID);
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static void BorrarCompetenciaByID(
            string competencia_id)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "borrarCompetencia";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cnn;

                cmd.Parameters.AddWithValue("@id", competencia_id);

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static void ModificarCompetenciaByID(
            Competencia competencia)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "modificarCategoria";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cnn;

                cmd.Parameters.AddWithValue("@id", competencia.Com_ID);
                cmd.Parameters.AddWithValue("@Nombre", competencia.Com_Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", competencia.Com_Descripcion);
                cmd.Parameters.AddWithValue("@FechaInicio", competencia.Com_FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin", competencia.Com_FechaFin);
                cmd.Parameters.AddWithValue("@Estado", competencia.Com_Estado);
                cmd.Parameters.AddWithValue("@Organizador", competencia.Com_Organizador);
                cmd.Parameters.AddWithValue("@Ubicacion", competencia.Com_Ubicacion);
                cmd.Parameters.AddWithValue("@Sponsors", competencia.Com_Sponsors);
                cmd.Parameters.AddWithValue("@Categoria", competencia.Cat_ID);
                cmd.Parameters.AddWithValue("@Disciplina", competencia.Dis_ID);

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static Competencia ObtenerCompetenciaById(int competencia_id)
        {
            Competencia competencia = null;

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Competencia WHERE Com_ID = @Com_ID";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@Com_ID", competencia_id);
                cnn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        competencia = new Competencia
                        {
                            Com_ID = reader.GetInt32(reader.GetOrdinal("Com_ID")),
                            Com_Nombre = reader.GetString(reader.GetOrdinal("Com_Nombre")),
                            Com_Descripcion = reader.IsDBNull(reader.GetOrdinal("Com_Descripcion")) ? null : reader.GetString(reader.GetOrdinal("Com_Descripcion")),
                            Com_FechaInicio = reader.GetDateTime(reader.GetOrdinal("Com_FechaInicio")),
                            Com_FechaFin = reader.GetDateTime(reader.GetOrdinal("Com_FechaFin")),
                            Com_Estado = reader.GetString(reader.GetOrdinal("Com_Estado")),
                            Com_Organizador = reader.GetString(reader.GetOrdinal("Com_Organizador")),
                            Com_Ubicacion = reader.GetString(reader.GetOrdinal("Com_Ubicacion")),
                            Com_Sponsors = reader.GetString(reader.GetOrdinal("Com_Sponsors")),
                            Cat_ID = reader.GetInt32(reader.GetOrdinal("Cat_ID")),
                            Dis_ID = reader.GetInt32(reader.GetOrdinal("Dis_ID"))
                        };
                    }
                }

                cnn.Close();
            }

            return competencia;
        }
    }
}


