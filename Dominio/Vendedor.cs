using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Dominio
{
    public class Vendedor : Usuario
    {
        [DisplayName("Cantidad de Ventas")]
        public int CantidadVentas { get; set; }
        public override string ToString()
        {
            return ApellidoNombre;
        }
    }
}
