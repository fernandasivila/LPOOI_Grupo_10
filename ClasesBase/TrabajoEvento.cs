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
        public static void ModificarEvento(Evento ev)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "modificarEvento";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Atleta", ev.Atl_ID);
            cmd.Parameters.AddWithValue("@Competencia", ev.Com_ID);
            cmd.Parameters.AddWithValue("@Id", ev.Eve_ID);
            cmd.Parameters.AddWithValue("@Estado", ev.Eve_Estado);
            cmd.Parameters.AddWithValue("@HoraFin", ev.Eve_HoraFin);
            cmd.Parameters.AddWithValue("@HoraInicio", ev.Eve_HoraIicio);

            Console.WriteLine("HORA DE INICIO: ", ev.Eve_HoraIicio);
            Console.WriteLine("HORA FIN:", ev.Eve_HoraFin);

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

        public static Evento getEventByComByAtl(int idAtleta, int idComp)
        {

            Evento oEvento = new Evento();

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "obtenerEvent";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param1;
            param1 = new SqlParameter("@Atleta", SqlDbType.Int);
            param1.Direction = ParameterDirection.Input;
            param1.Value = idAtleta;
            cmd.Parameters.Add(param1);

            SqlParameter param2;
            param2 = new SqlParameter("@Competencia", SqlDbType.Int);
            param2.Direction = ParameterDirection.Input;
            param2.Value = idComp;
            cmd.Parameters.Add(param2);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                oEvento.Atl_ID = Convert.ToInt32(dt.Rows[0]["Alt_ID"]);
                oEvento.Com_ID = Convert.ToInt32(dt.Rows[0]["Com_ID"]);
                oEvento.Eve_ID = Convert.ToInt32(dt.Rows[0]["Eve_ID"]);
                if (dt.Rows[0]["Eve_HorarioInicio"] != DBNull.Value)
                {
                    oEvento.Eve_HoraIicio = Convert.ToDateTime(dt.Rows[0]["Eve_HorarioInicio"]);
                }

                oEvento.Eve_Estado = dt.Rows[0]["Eve_Estado"].ToString();
                return oEvento;
            }
            return null;

        }
        public static DataTable obtenerResultadosCompetencia(int compId)
        {
            DataTable resultadosTable = new DataTable();
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString))
            {
                cnn.Open();
                using (SqlCommand command = new SqlCommand("obtenerResultadosCompetencia", cnn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CompID", compId);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(resultadosTable);
                    }
                }
            }
            return resultadosTable;
        }

        public static void contarParticipantes(int compId, out int participantes, out int descalificados, out int abandonos)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString))
            {
                    cnn.Open();
                    using (SqlCommand command = new SqlCommand("contarEventos", cnn))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@CompID", compId);

                        SqlParameter participantesParam = new SqlParameter("@Participantes", SqlDbType.Int);
                        participantesParam.Direction = ParameterDirection.Output;
                        command.Parameters.Add(participantesParam);

                        SqlParameter descalificadosParam = new SqlParameter("@Descalificados", SqlDbType.Int);
                        descalificadosParam.Direction = ParameterDirection.Output;
                        command.Parameters.Add(descalificadosParam);

                        SqlParameter abandonosParam = new SqlParameter("@Abandonos", SqlDbType.Int);
                        abandonosParam.Direction = ParameterDirection.Output;
                        command.Parameters.Add(abandonosParam);

                        command.ExecuteNonQuery();

                        participantes = (int)command.Parameters["@Participantes"].Value;
                        descalificados = (int)command.Parameters["@Descalificados"].Value;
                        abandonos = (int)command.Parameters["@Abandonos"].Value;
                    }
            }
        }

        public static DateTime? ObtenerHoraInicio(int competenciaId)
        {
            DateTime? horaInicio = null;
            using (SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString))
            {
                SqlCommand cmd = new SqlCommand("obtenerHoraInicioEvento", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CompetenciaId", competenciaId);

                SqlParameter horaInicioOuter = new SqlParameter("@HoraInicio", SqlDbType.DateTime)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(horaInicioOuter);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                if (horaInicioOuter.Value != DBNull.Value)
                {
                    horaInicio = (DateTime) horaInicioOuter.Value;
                }
            }
            return horaInicio;
        }

        public static int AnularInscripcion(int atletaId, int competenciaId)
        {
            using (SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString))
            {
                SqlCommand command = new SqlCommand("AnularInscripcion", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@AtletaId", atletaId);
                command.Parameters.AddWithValue("@CompetenciaId", competenciaId);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                return rowsAffected;
            }
        }

        public static List<Competencia> ObtenerListaCompetenciasPorAtleta(int atletaID)
        {
            List<Competencia> competencias = new List<Competencia>();

            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "ObtenerCompetenciasPorAtleta";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cnn;

                cmd.Parameters.AddWithValue("@AtletaID", atletaID);

                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Competencia competencia = new Competencia
                    {
                        Com_ID = (int)reader["com_ID"],
                        Com_Nombre = reader["com_Nombre"].ToString(),
                        Com_Descripcion = reader["com_Descripcion"].ToString(),
                        Com_FechaInicio = (DateTime)reader["com_FechaInicio"],
                        Com_FechaFin = (DateTime)reader["com_FechaFin"],
                        Com_Estado = reader["com_Estado"].ToString(),
                        Com_Organizador = reader["com_Organizador"].ToString(),
                        Com_Ubicacion = reader["com_Ubicacion"].ToString(),
                        Com_Sponsors = reader["com_Sponsors"].ToString(),
                        Cat_ID = (int)reader["cat_ID"],
                        Dis_ID = (int)reader["dis_ID"]
                    };
                    competencias.Add(competencia);
                }
            }
            return competencias;
        }

        public static void AcreditarInscripcion(int atletaID, int competenciaID)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString))
            {
                SqlCommand cmd = new SqlCommand("AcreditarInscripcion", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AtletaId", atletaID);
                cmd.Parameters.AddWithValue("@CompetenciaId", competenciaID);

                cnn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                cnn.Close();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Actualización exitosa. Filas afectadas: " + rowsAffected);
                }
                else
                {
                    Console.WriteLine("No se encontró el evento para actualizar.");
                }
            }
        }

        public static DataTable ObtenerCompetenciasPorAtleta(int atletaID)
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "ObtenerCompetenciasPorAtleta";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cnn;

                cmd.Parameters.AddWithValue("@AtletaID", atletaID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }
    }
}
