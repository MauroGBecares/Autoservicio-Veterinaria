using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
