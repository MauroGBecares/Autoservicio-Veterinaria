using Dominio;
using System;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class MenuVendedor : Form
    {
        /*
         * A esta ventana solo puede ingresar usuario como Vendedor en el cual puede ver los pedidos recibidos(dentro podra despacharlos),
         * ver listado de vendedores, listado de clientes/mascotas y puede crear un nuevo usuario como Vendedor.
         */
        private Vendedor user;
        public MenuVendedor(Vendedor vendedor)
        {
            this.user = vendedor;
            InitializeComponent();
        }

        private void btnPedidosRecibidos_Click_1(object sender, EventArgs e)
        {
            HistorialPedidos ventana = new HistorialPedidos(user);
            ventana.ShowDialog();
        }

        private void btnListadoVendedores_Click(object sender, EventArgs e)
        {
            ListasVendedoresClientes ventana = new ListasVendedoresClientes(user);
            ventana.ShowDialog();
        }

        private void btnMascotasClientes_Click(object sender, EventArgs e)
        {
            ListasVendedoresClientes ventana = new ListasVendedoresClientes();
            ventana.ShowDialog();
        }

        private void btnCrearNuevoVendedor_Click(object sender, EventArgs e)
        {
            RegistroUsuario ventana = new RegistroUsuario(user);
            ventana.ShowDialog();
        }

        private void MenuVendedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            InicioSesion ventana = new InicioSesion();
            ventana.Show();
        }
    }
}
