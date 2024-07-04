
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBase
{
    public class TrabajoDisciplina
    {
        private static string connectionString = ClasesBase.Properties.Settings.Default.comdepConnectionString;

        public static void AgregarDisciplina(Disciplina disciplina)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "agregarDisciplina";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cnn;

                cmd.Parameters.AddWithValue("@Nombre", disciplina.Dis_Nombre);
                if (!string.IsNullOrEmpty(disciplina.Dis_Descripcion))
                    cmd.Parameters.AddWithValue("@Descripcion", disciplina.Dis_Descripcion);

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static void BorrarDisciplinaPorID(
           int disciplina_id)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "borrarDisciplina";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cnn;

                cmd.Parameters.AddWithValue("@id", disciplina_id);

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static void ModificarDisciplinaPorID(
            Disciplina disciplina)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "modificarDisciplina";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cnn;

                cmd.Parameters.AddWithValue("@id", disciplina.Dis_ID);
                cmd.Parameters.AddWithValue("@Nombre", disciplina.Dis_Nombre);
                if (!string.IsNullOrEmpty(disciplina.Dis_Descripcion))
                    cmd.Parameters.AddWithValue("@Descripcion", disciplina.Dis_Descripcion);

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static DataTable ObtenerDisciplinas()
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "obtenerDisciplinas";
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Connection = cnn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;

            }

        }



      
        public static Disciplina ObtenerDisciplinaByID(int dis_Id)
        {
            Disciplina oDisciplina = new Disciplina();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("obtenerDisciplinaById");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", dis_Id);
                cnn.Open();
               
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                       
                        oDisciplina.Dis_ID = reader.GetInt32(reader.GetOrdinal("Dis_ID"));
                        oDisciplina.Dis_Nombre = reader.GetString(reader.GetOrdinal("Dis_Nombre"));

                        oDisciplina.Dis_Descripcion = reader.IsDBNull(reader.GetOrdinal("Dis_Decripcion")) ? null : reader.GetString(reader.GetOrdinal("Dis_Decripcion"));
                    }
                }
                cnn.Close();
            }
            return oDisciplina;
        }

        public static List<Disciplina> obtenerListaDisciplinas()
        {
            List<Disciplina> listaDisciplinas = new List<Disciplina>();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("obtenerDisciplinas", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cnn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Disciplina disciplina = new Disciplina()
                        {
                            Dis_ID = reader.GetInt32(reader.GetOrdinal("Dis_ID")),
                            Dis_Nombre = reader.GetString(reader.GetOrdinal("Dis_Nombre")),
                            Dis_Descripcion = reader.GetString(reader.GetOrdinal("Dis_Decripcion"))
                        };
                        listaDisciplinas.Add(disciplina);
                    }
                }
                cnn.Close();
            }
            return listaDisciplinas;
        }
    }
}

