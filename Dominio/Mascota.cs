using System.ComponentModel;

namespace Dominio
{
    public class Mascota
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Sexo { get; set; }
        public float Peso { get; set; }
        public int Edad { get; set; }
        [DisplayName("Esta Castrado?")]
        public bool EstaCastrado { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
