using Dominio;
using Helpers;
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
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void llblCrearCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistroUsuario ventana = new RegistroUsuario();
            ventana.ShowDialog();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario usuario = Utilities.buscarUsuario(txtUser.Text);
            if (usuario != null)
            {
                if (Utilities.validarPassword(usuario, txtPassword.Text))
                {
                    if (usuario is Cliente cliente)
                    {
                        MenuCliente ventanaCliente = new MenuCliente(cliente);
                        ventanaCliente.Show();
                        this.Hide();
                    }
                    else if (usuario is Vendedor vendedor)
                    {
                        MenuVendedor ventanaVendedor = new MenuVendedor(vendedor);
                        ventanaVendedor.Show();
                        this.Hide();
                    }
                    txtPassword.Clear();
                    txtUser.Clear();
                }
                else
                {
                    MessageBox.Show("La contraseña es incorrecta, intente nuevamente.");
                }
            }
            else if (string.IsNullOrEmpty(txtUser.Text))
            {
                MessageBox.Show("Ingrese un usuario.");
            }
            else
            {
                MessageBox.Show("El usuario ingresado no existe, si no posee cuenta cree una nueva.");
            }
        }
        private void InicioSesion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
