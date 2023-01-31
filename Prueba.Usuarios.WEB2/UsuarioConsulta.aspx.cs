using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prueba.Usuarios.WEB2
{
    public partial class UsuarioConsulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       private void Consultar()
        {
            using(ServiceReference2.UsuarioServiceClient client = new ServiceReference2.UsuarioServiceClient())
            {
                gv.DataSource = client.ListarUsuarios();
                gv.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        

      

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            string id;
            LinkButton BtnConsultar = (LinkButton)sender;

            GridViewRow selectedrow = (GridViewRow)BtnConsultar.NamingContainer;
            id = selectedrow.Cells[0].Text;

            Response.Redirect("~/Usuario.aspx?id=" + id + "&op=D");
        }


        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            string id;
            LinkButton BtnConsultar = (LinkButton)sender;

            GridViewRow selectedrow = (GridViewRow)BtnConsultar.NamingContainer;
            id = selectedrow.Cells[0].Text;

            Response.Redirect("~/Usuario.aspx?id=" + id + "&op=U");
        }
    }
}