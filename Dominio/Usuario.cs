using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Dominio
{
    public class Usuario
    {
        public string User { get; set; }
        public string Password { get; set; }
        [DisplayName("Apellido y Nombre")]
        public string ApellidoNombre { get; set; }
        [DisplayName("Dirección")]
        public string Direccion { get; set; }
    }
}
