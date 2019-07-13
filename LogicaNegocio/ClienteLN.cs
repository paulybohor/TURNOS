using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using EntidadNegocio;
using AccesoDatos;
using System.Data;

namespace LogicaNegocio
{
    public class ClienteLN
    {
        public ClienteLN()
        {
        }


        public void InsertCliente(ClienteDST dsCliente)
        {
            ClienteDALC cliente = new ClienteDALC();
            cliente.insertCliente(dsCliente);
        }


        public static List<ClienteDST> ListarCliente()
        {
            ClienteDALC cliente = new ClienteDALC();
            return cliente.ListarCliente();
        }


        public DataSet LIstaClientebyCodigo(int cliente)
        {
            ClienteDALC clientes = new ClienteDALC();
            return clientes.ListarClientebyEstado(cliente);
        }


        public int updateCliente(ClienteDST dsCliente)
        {
            return new ClienteDALC().updateCliente(dsCliente);

        }


        public int DeleteCliente(ClienteDST dsCliente)
        {
            return new ClienteDALC().DeleteCliente(dsCliente);
        }





    }

}