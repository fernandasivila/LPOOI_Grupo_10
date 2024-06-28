using System;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    internal class TrabajoCategoria
    {
        private static string connectionString = ClasesBase.Properties.Settings.Default.comdepConnectionString;

        public static void AddCategoria(
            Categoria categoria )
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "agregarCategoria";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cnn;

                cmd.Parameters.AddWithValue("@Nombre", categoria.Cat_Nombre);
                if (!string.IsNullOrEmpty(categoria.Cat_Descripcion))
                    cmd.Parameters.AddWithValue("@Descripcion", categoria.Cat_Descripcion);

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static void DeleteCategoriaById(
            string categoria_id )
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "borrarCategoria";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cnn;

                cmd.Parameters.AddWithValue("@id", categoria_id);

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static void ModifyCategoria(
            Categoria categoria )
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "modificarCategoria";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cnn;

                cmd.Parameters.AddWithValue("@Nombre", categoria.Cat_Nombre);
                if (!string.IsNullOrEmpty(categoria.Cat_Descripcion))
                    cmd.Parameters.AddWithValue("@Descripcion", categoria.Cat_Descripcion);

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
    }
}
