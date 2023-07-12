using System.Collections.Generic;

namespace Dominio
{
    public class Cliente : Usuario
    {
        public List<Mascota> Mascotas { get; set; }
        public List<Pedido> Pedidos { get; set; }
        public override string ToString()
        {
            return ApellidoNombre;
        }
    }
}
