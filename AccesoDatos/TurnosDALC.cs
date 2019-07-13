using EntidadNegocio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.SqlServer.Server;
using System.Data;

namespace AccesoDatos
{
    public class TurnosDALC
    {
        public TurnosDALC()
        {
        }


        public void insertTurno(TurnoDST dsTurno)
        {
            IDbConnection conn = DBComon.Conexion();
            conn.Open();
            SqlCommand Command = new SqlCommand("INSERT INTO TURNO ( COD_CLI, COD_COLA, FECHA, COD_CE) " +
            " VALUES ( @cod_cli, @cod_cola, @fecha, @cod_ce)", conn as SqlConnection);

            Command.CommandType = CommandType.Text;

            Command.Parameters.AddWithValue("cod_cli", dsTurno.Cod_cli);
            Command.Parameters.AddWithValue("cod_cola", dsTurno.Cod_cola);
            Command.Parameters.AddWithValue("fecha", dsTurno.Fecha);
            Command.Parameters.AddWithValue("cod_ce", dsTurno.Cod_ce);

            Command.ExecuteNonQuery();
            conn.Close();

        }


        public List<TurnoDST> ListarTurnos()
        {
            IDbConnection conn = DBComon.Conexion();
            conn.Open();

            SqlCommand Command = new SqlCommand("SELECT T.ID, (SELECT C.MODULO FROM COLA C WHERE C.COD_COLA = T.COD_COLA) MODULO,"+
            "(SELECT N.NOMBRE FROM CLIENTE N WHERE N.COD_CLI = T.COD_CE) NOMBRE, T.FECHA,"+
            "(SELECT E.ESTADO FROM CRITERIOS_ESTADO E WHERE E.COD_CE = T.COD_CE) ESTADO"+
            "FROM TURNO T WHERE t.COD_CE in ('1', '2')", conn as SqlConnection);
            Command.CommandType = CommandType.Text;
            IDataReader reader = Command.ExecuteReader();
            List<TurnoDST> lista = new List<TurnoDST>();
            while (reader.Read())
            {
                TurnoDST turno = new TurnoDST();
                turno.Id = reader.GetInt32(0);
                turno.Cod_cli = reader.GetInt32(1);
                turno.Cod_cola = reader.GetInt32(2);
                turno.Fecha = reader.GetDateTime(3);
                turno.Cod_ce = reader.GetInt32(4);

                lista.Add(turno);
            }

            conn.Close();
            return lista;
        }


        public DataSet ListarTurnobyCodigo(int turno)
        {
            IDbConnection conn = DBComon.Conexion();
            conn.Open();

            DataSet dataSet = null;
            TurnoDST turnos = new TurnoDST();
            DataTable dt = new DataTable();

            SqlCommand Command = new SqlCommand("SELECT T.ID, (SELECT C.MODULO FROM COLA C WHERE C.COD_COLA = T.COD_COLA) MODULO," +
            "(SELECT N.NOMBRE FROM CLIENTE N WHERE N.COD_CLI = T.COD_CE) NOMBRE, T.FECHA," +
            "(SELECT E.ESTADO FROM CRITERIOS_ESTADO E WHERE E.COD_CE = T.COD_CE) ESTADO" +
            "FROM TURNO T WHERE t.COD_CE in ('1', '2') and T.ID =" + turno + "'", conn as SqlConnection);
            Command.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(Command);
            dataSet = new DataSet();
            da.Fill(dataSet, "Turno");

            conn.Close();

            return dataSet;
        }


        public int updateTurnobyEstado(TurnoDST dsTurno)
        {
            IDbConnection conn = DBComon.Conexion();
            conn.Open();
            SqlCommand Command = new SqlCommand("UPDATE TURNO SET COD_CE = @Cod_ce  WHERE id = @id", conn as SqlConnection);
            Command.CommandType = CommandType.Text;

            Command.Parameters.Add(new SqlParameter("@id", dsTurno.Id));
            Command.Parameters.Add(new SqlParameter("@cod_ce", dsTurno.Cod_ce));

            int resultado = Command.ExecuteNonQuery();
            conn.Close();
            return resultado;
        }


        public int DeleteTurno(TurnoDST dsTurno)
        {
            IDbConnection conn = DBComon.Conexion();
            conn.Open();

            SqlCommand Command = new SqlCommand("delete TURNO where id = @id", conn as SqlConnection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.Add(new SqlParameter("@id", dsTurno.Id));

            int resultado = Command.ExecuteNonQuery();
            conn.Close();
            return resultado;

        }


    }








}