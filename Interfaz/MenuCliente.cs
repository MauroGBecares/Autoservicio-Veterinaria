using Dominio;
using System;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class MenuCliente : Form
    {
        /* 
         * Solo se ingresa a esta ventana si el usuario es cliente y puede realizar registro de mascotas,
         * realizar pedidos y ver historial de pedidos(se puede cancelar un pedido segun la condicion del mismo).
         */
        private Cliente user;
        public MenuCliente(Cliente cliente) 
        {
            this.user = cliente;
            InitializeComponent();
        }

        private void btnRegistrarMascota_Click(object sender, EventArgs e)
        {
            RegistrarMascota ventana = new RegistrarMascota(user);
            ventana.ShowDialog();
        }

        private void btnRealizarPedido_Click(object sender, EventArgs e)
        {
            CargarPedido ventana = new CargarPedido(user);
            ventana.ShowDialog();
        }

        private void btnVerHistoriaPedidos_Click(object sender, EventArgs e)
        {
            HistorialPedidos ventana = new HistorialPedidos(user);
            ventana.ShowDialog();
        }

        private void MenuCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            InicioSesion ventana = new InicioSesion();
            ventana.Show();
        }
    }
}
