using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Dominio
{
    public class Pedido
    {
        [DisplayName("Nro. Pedido")]
        public int CodigoPedido { get; set; }
        public string Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public string Vendedor { get; set; }
        [DisplayName("Cantidad (kg)")]
        public float CantidadPorKg { get; set; }
        [DisplayName("Cant. Compl. Dietarios")]
        public int ComplementosDietarios { get; set; }
        public string Estado { get; set; }
    }
}
