using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class OrdenCompra
    {
        private List<Disco> ListDiscos;
        private List<Cancion> ListCancion;

        public OrdenCompra()
        {
            ListDiscos = new List<Disco>();
            ListCancion = new List<Cancion>();
        }

        public void AgregarDisaco(Disco d) 
        {
            ListDiscos.Add(d);
        }

        public void AgregarDisaco(Cancion d)
        {
            ListCancion.Add(d);
        }

        public List<Disco> VerDiscos() {
            return ListDiscos;
        }

        public void EliminarDisco(String titulo) 
        {
            foreach(Disco d in ListDiscos)
            {
                if(d.Titulo.Equals(titulo))
                {
                    ListDiscos.Remove(d);
                }
            }
        }

        public void EliminarCancion(String titulo)
        {
            foreach (Cancion d in ListCancion)
            {
                if (d.Titulo.Equals(titulo))
                {
                    ListCancion.Remove(d);
                }
            }
        }

        public override string ToString()
        {
            return "No. Discos: " + ListDiscos.Count + "No. Canciones: " + ListCancion.Count;
        }
    }
}
