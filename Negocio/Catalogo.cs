using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Catalogo
    {

        public String Genero { get; set; }
        public List<Disco> Discos { get; set; }

        public Catalogo(String genero, List<Disco> discos)
        {
            Genero = genero;
            Discos = discos;
        }

        public Catalogo()
        {
            Genero = "Genero";
            Discos = null;
        }

        public override string ToString()
        {
            String cadena = "Genero: " + Genero + "\n" + "Discos: " + "\n\t";
            foreach(Disco d in Discos)
            {
                

            }
            return cadena;
                
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        

    }
}
