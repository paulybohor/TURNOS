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
    public class TurnoLN
    {
        public TurnoLN()
        {
        }

        public void InsertTurno(TurnoDST dsTurno)
        {
            TurnosDALC turno = new TurnosDALC();
            turno.insertTurno(dsTurno);
        }


        public static List<TurnoDST> ListarTurno()
        {
            TurnosDALC turno = new TurnosDALC();
            return turno.ListarTurnos();
        }

        public DataSet ListarTurnobyCodigo(int turno)
        {
            TurnosDALC turnos = new TurnosDALC();
            return turnos.ListarTurnobyCodigo(turno);
        }


        public int updateTurnobyEstado(TurnoDST dsTurno)
        {
            return new TurnosDALC().updateTurnobyEstado(dsTurno);

        }


        public int Eliminarturno(TurnoDST dsTurno)
        {
            return new TurnosDALC().DeleteTurno(dsTurno);
        }
    }
}