using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class Factura
    {
        private IPago Pago;
        private OrdenCompra orden;
        private Usuario User;

        public Factura(IPago pago, OrdenCompra orden, Usuario usuario)
        {
            this.Pago = pago;
            this.orden = orden;
            this.User = usuario;
        }

        private void facturar() 
        {
            Int32 total = 0;
            List<Disco> lista = orden.VerDiscos();
            foreach(Disco d in lista)
            {
                total = total + d.Precio;
                d.ContarVenta();
            }
            Pago.RealizarPago(total);
        }

        
    }
}
