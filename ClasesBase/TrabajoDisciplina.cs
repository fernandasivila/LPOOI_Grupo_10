
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
                //cmd.CommandText = "obtenerDisciplinas";
                //cmd.CommandType = CommandType.StoredProcedure;


                cmd.CommandText = "SELECT * FROM Disciplina";
                cmd.CommandType = CommandType.Text;

                cmd.Connection = cnn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;

            }

        }



        public static int? obtenerDisciplinaIdByNombre(string nombre)
        {

            int? id = null;
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                // Esto se reemplazará con un procedimiento almacenado
                string query = "SELECT Dis_ID FROM Disciplina WHERE Dis_Nombre = @Nombre";
                SqlCommand command = new SqlCommand(query, cnn);
                command.Parameters.AddWithValue("@Nombre", nombre);

                cnn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                cnn.Close();
            }
            return id;

        }

        public static Disciplina ObtenerDisciplinaByID(int id)
        {
            Disciplina disciplina = null;
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Disciplina WHERE Dis_ID = @Id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cnn;

                SqlParameter param = new SqlParameter("@Id", SqlDbType.Int);
                param.Value = id;
                cmd.Parameters.Add(param);

                cnn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        disciplina = new Disciplina();


                        disciplina.Dis_ID = reader.GetInt32(reader.GetOrdinal("Dis_ID"));
                        disciplina.Dis_Nombre = reader.GetString(reader.GetOrdinal("Dis_Nombre"));

                        disciplina.Dis_Descripcion = reader.IsDBNull(reader.GetOrdinal("Dis_Decripcion")) ? null : reader.GetString(reader.GetOrdinal("Dis_Decripcion"));
                    }
                }
            }
            return disciplina;
        }

    }
}

