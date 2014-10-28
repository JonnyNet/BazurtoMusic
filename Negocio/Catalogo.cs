using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Catalogo
    {

        public String Seccion { get; set; }
        public List<Disco> Discos { get; set; }
        public List<Cancion> Canciones { get; set; }

        public Catalogo(String genero, List<Disco> discos, List<Cancion> canciones)
        {
            Seccion = genero;
            Discos = discos;
            Canciones = canciones;
        }

        public Catalogo()
        {
            Seccion = "Genero";
            Discos = new List<Disco>();
            Canciones = new List<Cancion>();
        }

        public override string ToString()
        {
            String cadena = "Genero: " + Seccion + "\n" + "Discos: " + "\n\t";
            foreach(Disco d in Discos)
            {
                cadena += d.Titulo + "\n\t";
            }
            return cadena;
                
        }

        public override bool Equals(object obj)
        {
            Catalogo c = (Catalogo) obj;
            if (Seccion == c.Seccion && Discos == c.Discos)
                return true;


            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        

    }
}
