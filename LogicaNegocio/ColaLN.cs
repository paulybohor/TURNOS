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
    public class ColaLN
    {
        public ColaLN()
        {
        }


        public static List<ColaDST> ListarCola()
        {
            ColaDALC cola = new ColaDALC();
            return cola.ListarCola();
        }


    }
}