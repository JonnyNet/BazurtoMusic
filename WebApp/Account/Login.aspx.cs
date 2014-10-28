using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using WebApp.Models;
using Negocio;
using Datos;
using System.Collections.Generic;

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

            IEnumerable<Usuario> listusuarios = (IEnumerable<Usuario>)Datos.Datos.getUsuario();

            if (!user.Equals("") && !pass.Equals(""))
            {

                foreach(Usuario value in listusuarios)
                {
                    if(value.Nombre.Equals(user) && value.Password.Equals(pass))
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
                        FailureText.Text = "Error usuario o contraseña incorrectos";
                        ErrorMessage.Visible = true;
                    }
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