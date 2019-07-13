using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntidadNegocio
{
    public class TurnoDST
    {
        public int Id { get; set; }
        public int Cod_cola { get; set; }
        public int Cod_cli { get; set; }
        public DateTime Fecha { get; set; }
        public int Cod_ce { get; set; }

    }
}