using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public abstract class Music
    {
        public String Titulo { get; set; }
        public String Interprete { get; set; }
        public int Tamaño { get; set; }
        public String Genero { get; set; }
        public Int32 Precio { get; set; }
        public long Cantvendida { get; set; }
        public double Duracion { get; set; }

        public Music(string genero, string interprete, Int32 precio, Int32 tamaño, string titulo)
        {
            Titulo = titulo;
            Interprete = interprete;
            Tamaño = tamaño;
            Genero = genero;
            Precio = precio;
            Duracion = 0;
            Cantvendida = 0;
        }

        public Music(string genero, string titulo)
        {
            Titulo = titulo;
            Interprete = "";
            Tamaño = 0;
            Genero = genero;
            Precio = 0;
            Duracion = 0;
            Cantvendida = 0;
        }

        public Music()
        {
            Titulo = "Titulo";
            Interprete = "Interprete";
            Tamaño = 0;
            Genero = "Genero";
            Precio = 0;
            Duracion = 0;
            Cantvendida = 0;
        }

        public override string ToString()
        {
            return "Titulo: " + Titulo + "\n" +
                "Interprete: " + Interprete + "\n" +
                "Tamaño: " + Tamaño + "\n" +
                "Genero: " + Genero + "\n" +
                "Precio: " + Precio + "\n" +
                "Duracion: " + Duracion + "\n" +
                "Cantidad vendida" + Cantvendida + "\n";
        }

        public override bool Equals(object obj)
        {
            Music d = (Music)obj;
            bool result = false;

            if (Titulo == d.Titulo
                && Interprete == d.Interprete
                && Tamaño == d.Tamaño
                && Genero == d.Genero
                && Precio == d.Precio
                && Duracion == d.Duracion
                && Cantvendida == d.Cantvendida)
                return true;

            return result;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public abstract void ContarVenta();
    }
}
