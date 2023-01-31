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
                GridView1.DataSource = client.ListarUsuarios();
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Consultar();
        }
    }
}