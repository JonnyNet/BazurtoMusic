using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class Cancion : CD
    {
        private double Calidad { get; set; }
        private String Autor { get; set; }

        public Cancion(double duracion, String genero, String interprete, Int32 precio, Int32 tamaño, String titulo, double calidad, String autor)
            : base(genero,interprete,precio,tamaño,titulo)
        {
            Calidad = calidad;
            Autor = autor;
        }

        public Cancion():base()
        {
            Calidad = 0;
        }

        public override string ToString()
        {
            return base.ToString() +
                "Calidad: " + Calidad + "\n" +
                "Autor: " + Autor;
           
        }

        public override bool Equals(object obj)
        {
            Cancion d = (Cancion)obj;
                if (base.Equals(d) && Calidad == d.Calidad && Autor == d.Autor)
                    return true;

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    
        public override void ContarVenta()
        {
            this.Cantvendida++;
        }
    }
}
