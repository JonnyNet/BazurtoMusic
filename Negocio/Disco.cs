using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class Disco : Music
    {
        private List<Cancion> canciones;
        public int Nuntrack { get; set; }

        public Disco():base()
        {
            canciones = new List<Cancion>();
            Nuntrack = 0;
        }

        public Disco(String genero, String titulo)
            : base(genero,titulo)
        {
            canciones = new List<Cancion>();
        }

        public List<Cancion> Canciones
        {
            get { return canciones; }
        }

        public void AgregarCancion(Cancion cancion)
        {
            this.Duracion = this.Duracion + cancion.Duracion;
            this.Precio = this.Precio + cancion.Precio;
            this.Tamaño = this.Tamaño + cancion.Tamaño;
            this.Interprete = "Varios";
            canciones.Add(cancion);
            Nuntrack = canciones.Count;
        }

        

        public override string ToString()
        {
            String cadena = base.ToString() + 
                "Numero de canciones: " + Nuntrack + "\n" + "Canciones: ";
            if(Canciones != null)
            {            
                foreach(Cancion disco in Canciones)
                {
                    cadena += disco.Titulo;
                }
            }
            return cadena;
        }

        public override bool Equals(object obj)
        {
            Disco d = (Disco)obj;
            try
            {
                if (base.Equals(d) && Nuntrack == d.Nuntrack && Canciones == d.Canciones)
                    return true;
            }catch(NullReferenceException e)
            {
                Console.WriteLine(e);
                return false;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        


        public override void ContarVenta()
        {
            this.Cantvendida++;
            foreach(Cancion cancion in this.Canciones)
            {
                cancion.ContarVenta();
            }
        }
    }
}
