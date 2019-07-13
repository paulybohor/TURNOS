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
    public partial class Cliente : System.Web.UI.Page
    {


        private readonly ClienteDALC proxyc = new ClienteDALC();

        ClienteDST dsCliente = new ClienteDST();

        ClienteLN dsCli = new ClienteLN();


        protected void Page_Load(object sender, EventArgs e)
        {
            CargarCLiente();
        }


        protected void btnAgregar_Click(object sender, EventArgs e)
        {

            //LimpiarCampos();

            pcCliente.ShowOnPageLoad = true;
        }


        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarModificarCliente();
            CargarCLiente();
            btnGuardar.Enabled = false;
        }


        protected void gvCliente_CustomButtonCallback(object sender, ASPxGridViewCustomButtonCallbackEventArgs e)
        {
            if (e.ButtonID == "Modificar")
            {
                BloquearCampos();
                pcCliente.ShowOnPageLoad = true;
                lblCodigo.Text = Convert.ToString(gvCliente.GetRowValues(e.VisibleIndex, "turno").ToString());
                CargarInformacionCLiente(Convert.ToInt32(gvCliente.GetRowValues(e.VisibleIndex, "turno")));

            }
            if (e.ButtonID == "Eliminar")

            {
                //int visibleIndex1 = Convert.ToInt32(e.VisibleIndex);
                //dele
                //DeleteCliente(Convert.ToString(gvCliente.GetRowValues(e.VisibleIndex, "Cliente")));

            }

        }

       
        public void BloquearCampos()
        {
            //.Enabled = false;
            //cmbModulo.Enabled = false;
        }


        public void CargarCLiente()
        {
            gvCliente.DataSource = null;
            gvCliente.DataSource = proxyc.ListarCliente();
            gvCliente.DataBind();

        }

        public void CargarInformacionCLiente(int cliente)
        {
            DataSet cli = proxyc.ListarClientebyEstado(cliente);
            DataTable datacli = cli.Tables[0];
            DataRow dataRow = cli.Tables[0].Rows[0];

            txtCedula.Text = Convert.ToString(dataRow["Cedula"]);
            txtNombre.Text = Convert.ToString(dataRow["Nombre"]);
            txtTelefono.Text = Convert.ToString(dataRow["Telefono"]);
            txtCorreo.Text = Convert.ToString(dataRow["Correo"]);
            txtCelular.Value = Convert.ToString(dataRow["Celular"]);

        }

        public void GuardarModificarCliente()
        {

            string cliente = lblCodigo.Text.ToString();
            ClienteDST cliented = new ClienteDST();

            if (cliente == "")
            {
                cliented.Cedula = txtCedula.Text.ToString();
                cliented.Nombre = txtNombre.Text.ToString();
                cliented.Telefono = txtTelefono.Value.ToString();
                cliented.Correo = txtCorreo.Value.ToString();
                cliented.Celular = txtCelular.Value.ToString();

                dsCli.InsertCliente(cliented);
                lblError1.Text = "Cliente Guardado";
            }
            else
            {

                lblError1.Text = "Consulte con su proveedor";
            }

        }

    }
}