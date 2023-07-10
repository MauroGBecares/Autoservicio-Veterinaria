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
    public partial class MenuCliente : Form
    {
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

        private void MenuCliente_Load(object sender, EventArgs e)
        {

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
