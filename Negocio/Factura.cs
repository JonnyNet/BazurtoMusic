using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class Factura
    {
        private IPago Pago;
        private Disco Cd;
        private Usuario User;

        public Factura(IPago pago, Disco disco, Usuario usuario)
        {
            this.Pago = pago;
            this.Cd = disco;
            this.User = usuario;
        }

        private void facturar() 
        {
            Int32 total = Cd.Precio;
        }
    }
}
