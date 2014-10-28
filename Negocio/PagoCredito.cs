using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class PagoCredito: IPago
    {
        String Nombre { get; set; }

        public PagoCredito(String nombre)
        {
            Nombre = nombre;
        }

        public bool RealizarPago(int valor)
        {
            return true;
        }
    }
}
