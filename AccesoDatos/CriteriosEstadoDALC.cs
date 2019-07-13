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
    public class CriteriosEstadoDALC
    {

        public CriteriosEstadoDALC()
        {
        }


        public List<CriterioEstadoDST> ListarCriterioEstadoTurno()
        {
            IDbConnection conn = DBComon.Conexion();
            conn.Open();

            SqlCommand Command = new SqlCommand("SELECT COD_CE, CRITERIO, TIPO, DESCRIPCION, ESTADO FROM CRITERIOS_ESTADO WHERE CRITERIO = 'est_tur'", conn as SqlConnection);
            Command.CommandType = CommandType.Text;
            IDataReader reader = Command.ExecuteReader();
            List<CriterioEstadoDST> lista = new List<CriterioEstadoDST>();
            while (reader.Read())
            {
                CriterioEstadoDST criterioEstado = new CriterioEstadoDST();

                criterioEstado.Cod_ce = reader.GetInt32(0);
                criterioEstado.Criterio = reader.GetString(1);
                criterioEstado.Tipo = reader.GetString(2);
                criterioEstado.Estado = reader.GetString(3);

                lista.Add(criterioEstado);
            }

            conn.Close();
            return lista;


        }


        public List<CriterioEstadoDST> ListarCriterioEstadoCola()
        {
            IDbConnection conn = DBComon.Conexion();
            conn.Open();

            SqlCommand Command = new SqlCommand("SELECT COD_CE, CRITERIO, TIPO, DESCRIPCION, ESTADO FROM CRITERIOS_ESTADO WHERE CRITERIO = 'est_col'", conn as SqlConnection);
            Command.CommandType = CommandType.Text;
            IDataReader reader = Command.ExecuteReader();
            List<CriterioEstadoDST> lista = new List<CriterioEstadoDST>();
            while (reader.Read())
            {
                CriterioEstadoDST criterioEstado = new CriterioEstadoDST();

                criterioEstado.Cod_ce = reader.GetInt32(0);
                criterioEstado.Criterio = reader.GetString(1);
                criterioEstado.Tipo = reader.GetString(2);
                criterioEstado.Estado = reader.GetString(3);

                lista.Add(criterioEstado);
            }

            conn.Close();
            return lista;


        }


    }
}