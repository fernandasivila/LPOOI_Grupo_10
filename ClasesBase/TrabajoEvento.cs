using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBase
{
    public class TrabajoEvento
    {
        public static void AgregarEvento(Evento evento)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "agregarEvento";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param1;
            param1 = new SqlParameter("@Competencia", SqlDbType.Int);
            param1.Direction = ParameterDirection.Input;
            param1.Value = evento.Com_ID;
            cmd.Parameters.Add(param1);

            SqlParameter param2;
            param2 = new SqlParameter("@Atleta", SqlDbType.Int);
            param2.Direction = ParameterDirection.Input;
            param2.Value = evento.Atl_ID;
            cmd.Parameters.Add(param2);

            SqlParameter param3;
            param3 = new SqlParameter("@Estado", SqlDbType.VarChar);
            param3.Direction = ParameterDirection.Input;
            param3.Value = evento.Eve_Estado;
            cmd.Parameters.Add(param3);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static bool verificarInscripcionPrevia(int Com_ID, int Alt_ID)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "verificarInscripcion";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param1;
            param1 = new SqlParameter("@Competecia", SqlDbType.Int);
            param1.Direction = ParameterDirection.Input;
            param1.Value = Com_ID;
            cmd.Parameters.Add(param1);

            SqlParameter param2;
            param2 = new SqlParameter("@Atleta", SqlDbType.Int);
            param2.Direction = ParameterDirection.Input;
            param2.Value = Alt_ID;
            cmd.Parameters.Add(param2);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt.Rows.Count == 0;
        }
    }
}
