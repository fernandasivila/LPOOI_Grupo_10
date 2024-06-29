using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajoCategoria
    {
        private static string connectionString = ClasesBase.Properties.Settings.Default.comdepConnectionString;

        public static void AgregarCategoria(
            Categoria categoria)
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

        public static void BorrarCategoriaPorID(
            string categoria_id)
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

        public static void ModificarCategoriaPorID(
            Categoria categoria)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "modificarCategoria";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cnn;

                cmd.Parameters.AddWithValue("@id", categoria.Cat_ID);
                cmd.Parameters.AddWithValue("@Nombre", categoria.Cat_Nombre);
                if (!string.IsNullOrEmpty(categoria.Cat_Descripcion))
                    cmd.Parameters.AddWithValue("@Descripcion", categoria.Cat_Descripcion);

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static DataTable ObtenerCategorias()
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "obtenerCategorias";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cnn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }

        }
        public static Categoria ObtenerCategoriaById(
            int categoria_id)
        {
            Categoria oCategoria = new Categoria();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("obtenerCategoriaById", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", categoria_id);
                cnn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        oCategoria.Cat_Nombre = reader.GetString(reader.GetOrdinal("Cat_Nombre"));
                        if(!reader.IsDBNull(reader.GetOrdinal("Cat_Descripcion")))
                            oCategoria.Cat_Descripcion = reader.GetString(reader.GetOrdinal("Cat_Descripcion"));
                    }
                }
                cnn.Close();
            }
            return oCategoria;
        }
        public static List<Categoria> ObtenerListaCategorias()
        {
            List<Categoria> listaCategorias = new List<Categoria>();

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("obtenerCategorias", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cnn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Categoria categoria = new Categoria
                        {
                            Cat_ID = reader.GetInt32(reader.GetOrdinal("Cat_ID")),
                            Cat_Nombre = reader.GetString(reader.GetOrdinal("Cat_Nombre")),
                            Cat_Descripcion = reader.IsDBNull(reader.GetOrdinal("Cat_Descripcion")) ? null : reader.GetString(reader.GetOrdinal("Cat_Descripcion"))
                        };
                        listaCategorias.Add(categoria);
                    }
                }
                cnn.Close();
            }
            return listaCategorias;
        }
    }
}

