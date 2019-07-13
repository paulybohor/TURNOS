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
    public class ColaDALC
    {
        public ColaDALC()
        {
        }


        public List<ColaDST> ListarCola()
        {
            IDbConnection conn = DBComon.Conexion();
            conn.Open();

            SqlCommand Command = new SqlCommand("SELECT COD_COLA, TIEMPO, MODULO, COD_CE FROM COLA WHERE COD_CE IN ('1')", conn as SqlConnection);
            Command.CommandType = CommandType.Text;
            IDataReader reader = Command.ExecuteReader();
            List<ColaDST> lista = new List<ColaDST>();
            while (reader.Read())
            {
                ColaDST cola = new ColaDST();

                cola.Cod_cola = reader.GetInt32(0);
                cola.Tiempo = reader.GetInt32(1);
                cola.Modulo = reader.GetString(2);
                cola.Cod_ce = reader.GetInt32(3);

                lista.Add(cola);
            }

            conn.Close();
            return lista;


        }

    }
}