using System;
using System.ComponentModel;

namespace Dominio
{
    public class Pedido
    {
        [DisplayName("Nro. Pedido")]
        public int CodigoPedido { get; set; }
        public string Cliente { get; set; }
        [DisplayName("Fecha y Hora")]
        public DateTime Fecha { get; set; }
        public string Vendedor { get; set; }
        [DisplayName("Cantidad (kg)")]
        public float CantidadPorKg { get; set; }
        [DisplayName("Cant. Compl. Dietarios")]
        public int ComplementosDietarios { get; set; }
        public string Estado { get; set; }
    }
}
