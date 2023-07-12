using Dominio;
using Helpers;
using System;
using System.Windows.Forms;

namespace Interfaz
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
            ventana.ShowDialog(); // Esta ventana me dirige al registro del usuario como Cliente.
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario usuario = Utilities.buscarUsuario(txtUser.Text); //La funcion buscarUsuario me trae el usuario del DB.
            if (usuario != null) // Pregunta si el usuario ingresado existe en la DB.
            {
                if (Utilities.validarPassword(usuario, txtPassword.Text)) //Valido si la contraseña ingresada corresponde a la del usuario.
                {
                    if (usuario is Cliente cliente) // Si el usuario es cliente, me abre el menú de cliente sino me abre el menú de Vendedor.
                    {
                        MenuCliente ventanaCliente = new MenuCliente(cliente);
                        ventanaCliente.Show();
                        this.Hide();
                    }
                    else if (usuario is Vendedor vendedor)
                    {
                        MenuVendedor ventanaVendedor = new MenuVendedor(vendedor);
                        ventanaVendedor.Show();
                        this.Hide(); // Esconde la ventana de iniciar sesion luego de ejecutar la ventana del menú.
                    }
                    txtPassword.Clear();
                    txtUser.Clear();
                }
                else
                {
                    MessageBox.Show("La contraseña es incorrecta, intente nuevamente."); //Si el usuario no es encuentra me tira este mensaje.
                }
            }
            else if (string.IsNullOrEmpty(txtUser.Text)) // Valida si se ingreso un usuario.
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
