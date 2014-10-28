using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using WebApp.Models;
using Negocio;

namespace WebApp.Account
{
    public partial class Login : Page
    {
        OrdenCompra orden;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["orden"] != null)
            {
                orden = (OrdenCompra)Session["orden"];
            }
        }

        protected void LogIn(object sender, EventArgs e)
        {
            String user = Usuario.Text;
            String pass = Password.Text;

            if (!user.Equals("") && !pass.Equals(""))
            {
                if (orden != null)
                {
                    Session["user"] = user;
                    Server.Transfer("/Pagos.aspx", true);
                }
                else
                {
                    Session["user"] = user;
                    Server.Transfer("/Musica.aspx", true);
                }
            }
            else
            {
                FailureText.Text = "Llene los campos Email y Password";
                ErrorMessage.Visible = true;
            }

        }
    }
}