using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace AccesoDatos
{
    public static class DBComon
    {


        private static string Conn = @"Server = LOCALHOST; data source = MSSQLSERVER; Database=TURNOS; User ID = adam; Password=adam2019";

        public static IDbConnection Conexion()
        {
            return new SqlConnection(Conn);
        }

        public static IDbCommand ObtenerComando(string pComando, IDbConnection pCnn)
        {
            return new SqlCommand(pComando, pCnn as SqlConnection);
        }
    }
}