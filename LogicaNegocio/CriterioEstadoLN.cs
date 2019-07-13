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
    public class CriterioEstadoLN
    {
        public CriterioEstadoLN()
        {
        }


        public static List<CriterioEstadoDST> ListarCriterioEstadoTurno()
        {
            CriteriosEstadoDALC criterioEstado = new CriteriosEstadoDALC();
            return criterioEstado.ListarCriterioEstadoTurno();
        }

        public static List<CriterioEstadoDST> ListarCriterioEstadoCola()
        {
            CriteriosEstadoDALC criterioEstado = new CriteriosEstadoDALC();
            return criterioEstado.ListarCriterioEstadoCola();
        }

    }
}