using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public interface IPago
    {
        bool RealizarPago(Int32 valor);
    }
}
