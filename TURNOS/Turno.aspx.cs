using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using System.Collections.Generic;
using System.Resources;
using System.Globalization;
using System.Threading;
using System.IO;
using System.Net;
using DevExpress.Web;
using EntidadNegocio;
using AccesoDatos;
using LogicaNegocio;




namespace TURNOS
{
    public partial class Turno : System.Web.UI.Page
    {

        private readonly TurnosDALC proxyc = new TurnosDALC();

        TurnoDST dsTurno = new TurnoDST();

        TurnoLN dsTur = new TurnoLN();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

        }


        protected void gvTurno_CustomButtonCallback(object sender, ASPxGridViewCustomButtonCallbackEventArgs e)
        {
            if (e.ButtonID == "Modificar")
            {
                pcTurno.ShowOnPageLoad = true;
                lblCodigo.Text = Convert.ToString(gvTurno.GetRowValues(e.VisibleIndex, "Turno").ToString());
                CargarInformacionTurno(Convert.ToInt32(gvTurno.GetRowValues(e.VisibleIndex, "Turno")));

            }
            if (e.ButtonID == "Eliminar")

            {
                //int visibleIndex1 = Convert.ToInt32(e.VisibleIndex);
                //DeleteTurno(Convert.ToString(gvTurno.GetRowValues(e.VisibleIndex, "Turno")));

            }

        }


       
        public void CargarCLiente()
        {
            gvTurno.DataSource = null;
            gvTurno.DataSource = proxyc.ListarTurnos();
            gvTurno.DataBind();

        }

        public void CargarInformacionTurno(int turno)
        {
            DataSet tur = proxyc.ListarTurnobyCodigo(turno);
            DataTable datacli = tur.Tables[0];
            DataRow dataRow = tur.Tables[0].Rows[0];

            cmbModulo.Text = Convert.ToString(dataRow["Cod_cola"]);
            cmbNombre.Text = Convert.ToString(dataRow["Cod_cli"]);
            dateFecha.Text = Convert.ToString(dataRow["Fecha"]);
            cmbEstado.Text = Convert.ToString(dataRow["Cod_ce"]);

        }

        public void GuardarModificarCliente()
        {

            string turno = lblCodigo.Text.ToString();
            TurnoDST turnod = new TurnoDST();

            if (turno == "")
            {
                turnod.Cod_cola = Convert.ToInt32(cmbModulo.Value.ToString());
                turnod.Cod_cli = Convert.ToInt32(cmbNombre.Text.ToString());
                turnod.Fecha = Convert.ToDateTime(dateFecha.Date);
                turnod.Cod_ce = Convert.ToInt32(cmbEstado.Value.ToString()); 

                dsTur.InsertTurno(turnod);
                lblError1.Text = "Turno Guardado";
            }
            else
            {

                lblError1.Text = "Consulte con su proveedor";
            }

        }


    }
}