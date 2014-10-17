using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class PagoOnline: IPago
    {
        public bool RealizarPago(int valor)
        {
            ///aqui va la logica del pago en linea
            return true;
        }
    }
}
