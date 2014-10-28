using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace WebApp
{
    public partial class Pagos : System.Web.UI.Page
    {
        OrdenCompra orden;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                String user = (String)Session["user"];
                User.Text = "Hola " + user;
            }

            if (Session["orden"] != null)
            {
                orden = (OrdenCompra)Session["orden"];
                prueba.Text = orden.ToString();

            }
        }
    }
}