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

    public class ClienteDALC
    {
        public ClienteDALC()
            {
            }

        public void insertCliente( ClienteDST dsCliente)
                {
            IDbConnection conn = DBComon.Conexion();
                conn.Open();
                SqlCommand Command = new SqlCommand("INSERT INTO CLIENTE (CEDULA, NOMBRE, TELEFONO, CORREO, CELULAR) "+
                " VALUES (@cedula, @nombre, @telefono, @correo, @celular)", conn as SqlConnection);

            Command.CommandType = CommandType.Text;

            Command.Parameters.AddWithValue("cedula", dsCliente.Cedula);
            Command.Parameters.AddWithValue("nombre", dsCliente.Nombre);
            Command.Parameters.AddWithValue("telefono", dsCliente.Telefono);
            Command.Parameters.AddWithValue("correo", dsCliente.Correo);
            Command.Parameters.AddWithValue("celular", dsCliente.Celular);

            Command.ExecuteNonQuery();
            conn.Close();

        }


        public List<ClienteDST> ListarCliente()
        {
            IDbConnection conn = DBComon.Conexion();
            conn.Open();

            SqlCommand Command = new SqlCommand ("SELECT COD_CLI, CEDULA, NOMBRE, TELEFONO, CORREO, CELULAR FROM CLIENTE", conn as SqlConnection);
            Command.CommandType = CommandType.Text;
            IDataReader reader = Command.ExecuteReader();
            List<ClienteDST> lista = new List<ClienteDST>();
            while (reader.Read())
            {
                ClienteDST cliente = new ClienteDST();
                cliente.Cedula = reader.GetString(0);
                cliente.Cedula = reader.GetString(1);
                cliente.Nombre = reader.GetString(2);
                cliente.Telefono = reader.GetString(3);
                cliente.Correo = reader.GetString(4);
                cliente.Celular = reader.GetString(5);

                lista.Add(cliente);
            }

            conn.Close();
            return lista;
        }


        public DataSet ListarClientebyEstado(int cliente)
        {
            IDbConnection conn = DBComon.Conexion();
            conn.Open();

            DataSet dataSet = null;
            ClienteDST clientes = new ClienteDST();
            DataTable dt = new DataTable();

            SqlCommand Command = new SqlCommand("SELECT CEDULA, NOMBRE, TELEFONO, CORREO, CELULAR FROM CLIENTE WHERE COD_CLI'" + cliente + "'", conn as SqlConnection);
            Command.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(Command);
            dataSet = new DataSet();
            da.Fill(dataSet, "Cliente");

            conn.Close();

            return dataSet;
        }

        

        public int updateCliente(ClienteDST dsCliente)
        {
            IDbConnection conn = DBComon.Conexion();
            conn.Open();
            SqlCommand Command = new SqlCommand("UPDATE CLIENTE SET NOMBRE = @nombre, TELEFONO = @telefono, "+
               "CORREO = @correo, CELULAR = @celular  WHERE  COD_CLI= @cod_cli", conn as SqlConnection);
            Command.CommandType = CommandType.Text;

            Command.Parameters.Add(new SqlParameter("@cod_cli", dsCliente.Cod_cli));
            Command.Parameters.Add(new SqlParameter("@cedula", dsCliente.Cedula));
            Command.Parameters.Add(new SqlParameter("@nombre", dsCliente.Nombre));
            Command.Parameters.Add(new SqlParameter("@telefono", dsCliente.Telefono));
            Command.Parameters.Add(new SqlParameter("@correo", dsCliente.Correo));
            Command.Parameters.Add(new SqlParameter("@celular", dsCliente.Celular));

            int resultado = Command.ExecuteNonQuery();
            conn.Close();
            return resultado;


        }

        
        public int DeleteCliente(ClienteDST dsCliente)
        {
            IDbConnection conn = DBComon.Conexion();
            conn.Open();

            SqlCommand Command = new SqlCommand ("delete  cliente where cod_cli = @cod_cli", conn as SqlConnection);
            Command.CommandType = CommandType.Text;
            Command.Parameters.Add(new SqlParameter("@cod_cli", dsCliente.Cedula));

            int resultado = Command.ExecuteNonQuery();
            conn.Close();
            return resultado;

        }

    }
    
    
    
}