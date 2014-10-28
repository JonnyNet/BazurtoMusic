using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace WebApp
{
    public partial class Musica : System.Web.UI.Page
    {
        String user;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                user = (String)Session["user"];
                Email.Text = "Hola " + user;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            OrdenCompra orden = new OrdenCompra();

            ObjectDataSource grid1 = ObjectDataSource1;
            IEnumerable<Disco> o = (IEnumerable<Disco>)grid1.Select();

            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                GridViewRow row = GridView1.Rows[i];
                CheckBox check = row.FindControl("Select") as CheckBox;

                if (check.Checked)
                {
                    Disco aux = o.ElementAt(i);
                    orden.AgregarDisaco(aux);
                }
            }


            ObjectDataSource grid2 = ObjectDataSource2;
            IEnumerable<Cancion> u = (IEnumerable<Cancion>)grid2.Select();

            for (int i = 0; i < GridView2.Rows.Count; i++)
            {
                GridViewRow row = GridView2.Rows[i];
                CheckBox check = row.FindControl("Select") as CheckBox;

                if (check.Checked)
                {
                    Cancion aux = u.ElementAt(i);
                    orden.AgregarDisaco(aux);
                }
            }
            prueba.Text = orden.ToString();


            if (user != null)
            {
                Session["orden"] = orden;
                Server.Transfer("/Pagos.aspx", true);

            }
            else
            {
                Session["orden"] = orden;
                Server.Transfer("Account/Login.aspx", true);
            }

        }
    }
}