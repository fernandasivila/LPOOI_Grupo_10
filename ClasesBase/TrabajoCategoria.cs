﻿using System;
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
    }
}