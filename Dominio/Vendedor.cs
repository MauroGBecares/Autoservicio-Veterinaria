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
