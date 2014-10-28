using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class PagoDebito: IPago
    {
        String Nombre { get; set; }


        public PagoDebito(String nombre)
        {
            Nombre = nombre;
        }

        public bool RealizarPago(int valor)
        {
            ///aqui va la logica del pago en linea
            return true;
        }
    }
}
