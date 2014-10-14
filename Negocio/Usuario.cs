using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class Usuario
    {
       
        /// <summary>
        /// nombre de la persona
        /// </summary>
        public String Nombre { get; set; }
        /// <summary>
        /// contraseña de la persona
        /// </summary>
        public String Password { get; set; }
        /// <summary>
        /// facha de naciemieno de la persona
        /// </summary>
        public String Fechanacimiento { get; set; }
        /// <summary>
        /// tipo de persona para el sistema
        /// </summary>
        public String Tipo { get; set; }

        /// <summary>
        /// email del usuario
        /// </summary>
        public String Email { get; set; }

        /// <summary>
        /// numero de identificacion del usuario
        /// </summary>
        public Int64 Cedula { get; set; }


        public Usuario(String nombre, String password, String fechanacimmiento, String tipo, String email, long cedula)
        {
            Nombre = nombre;
            Password = password;
            Fechanacimiento = fechanacimmiento;
            Tipo = tipo;
            Email = email;
            Cedula = cedula;
 
        }

        public Usuario()
        {
            Nombre = "User";
            Password = "";
            Fechanacimiento = "Facha";
            Tipo = "Standaar";
            Email = "Email";
            Cedula = 0;
        }

        public override string ToString()
        {
            return "Titulo: " + Nombre + "\n" +
                "Password: " + Password + "\n" +
                "Fecha de Naciemiento: " + "\n" +
                "Tipo de Usuario: " + Tipo + "\n" +
                "Email: " + Email + "\n" +
                "Cedula: " + Cedula + "\n";
        }

        public override bool Equals(object obj)
        {
            Usuario d = (Usuario)obj;
            bool result = false;

            if (Nombre == d.Nombre
                && Password == d.Password
                && Fechanacimiento == d.Fechanacimiento
                && Tipo == d.Tipo
                && Cedula == d.Cedula
                && Email == d.Email)
                return true;

            return result;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}

