using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    internal class TrabajoCategoria
    {
        private static string connectionString = ClasesBase.Properties.Settings.Default.comdepConnectionString;

        //TODO: Implementar el Stored Procedure en la BD
        public static void AddCategoria(
            Categoria categoria )
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "AgregarCategoria";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cnn;

                cmd.Parameters.AddWithValue("@Nombre", categoria.Cat_Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", categoria.Cat_Descripcion);

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        //TODO: Implementar el Stored Procedure en la BD
        public static void DeleteCategoriaById(
            string categoria_id )
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "BorrarCategoria";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cnn;

                cmd.Parameters.AddWithValue("@ID", categoria_id);

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        //TODO: Implementar el Stored Procedure en la BD
        public static void ModifyCategoria(
            Categoria categoria )
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "ModificarCategoria";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cnn;

                cmd.Parameters.AddWithValue("@Nombre", categoria.Cat_Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", categoria.Cat_Descripcion);

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
    }
}
