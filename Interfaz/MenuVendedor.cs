using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_test_L2
{
    public partial class MenuVendedor : Form
    {
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
