using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prueba.Usuarios.WEB2
{
    public partial class Usuario : System.Web.UI.Page
    {

        public static string sID = "-1";
        public static string sOpc = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    sID = Request.QueryString["id"].ToString();
                }
                if (Request.QueryString["op"] != null)
                {
                    sOpc = Request.QueryString["op"].ToString();
                    switch (sOpc)
                    {
                        case "C":
                            CargarDatos(sOpc);
                            break;
                        case "R":

                            //cargar services select
                            CargarDatos(sOpc);
                            break;
                        case "U":


                            using (ServiceReference2.UsuarioServiceClient client = new ServiceReference2.UsuarioServiceClient())
                            {
                              
                              tbFecha.Text = Convert.ToDateTime ( client.ObtenerUsuario(1).FechaNacimiento).ToString("yyyy-MM-dd"); ;
                                tbNombres.Text =  client.ObtenerUsuario(1).Nombre;
                                tbIdUsuario.Text= Convert.ToString (client.ObtenerUsuario(1).IdUsuario);
                            }
                            //CargarDatos(sOpc);
                            break;
                        case "D":
                            CargarDatos(sOpc);
                            break;
                    }
                }
            }



        }

        void CargarDatos(string sOpc)
        {
            if (sOpc == "U" || sOpc == "R")
            {
                Response.Redirect("/usuarios.aspx");


            }
            else if (sOpc == "D")
            {
               //llamar opcion servicio
                Response.Redirect("/usuarios.aspx");
            }
        }


    }
}
