using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class OrdenCompra
    {
        private List<Disco> ListDiscos;

        public OrdenCompra()
        {
            ListDiscos = new List<Disco>();
        }

        public void AgregarDisaco(Disco d) 
        {
            ListDiscos.Add(d);
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
    }
}
