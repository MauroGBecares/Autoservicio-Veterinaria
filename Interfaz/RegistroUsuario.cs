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
    public partial class RegistroUsuario : Form
    {
        private Usuario user = null;
        public RegistroUsuario()
        {
            InitializeComponent();
            Text = "Registrarse como Cliente";
        }
        public RegistroUsuario(Vendedor vendedor)
        {
            this.user = vendedor;
            InitializeComponent();
            Text = "Crear nueva cuenta Vendedor";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!(validarCarga()))
                return;

            if (user == null)
            {
                Usuario nuevoCliente = new Cliente();
                nuevoCliente.ApellidoNombre = txtApellido.Text + ", " + txtNombre.Text;
                nuevoCliente.User = txtNombreUsuario.Text;
                nuevoCliente.Password = txtPassword.Text;
                nuevoCliente.Direccion = txtDireccion.Text;
                if (nuevoCliente is Cliente cliente)
                {
                    cliente.Mascotas = new List<Mascota>();
                    cliente.Pedidos = new List<Pedido>();   
                }
                Database.Usuarios.Add(nuevoCliente);
                Close();
            }
            else
            {
                Usuario nuevoVendedor = new Vendedor();
                nuevoVendedor.ApellidoNombre = txtApellido.Text + ", " + txtNombre.Text;
                nuevoVendedor.User = txtNombreUsuario.Text;
                nuevoVendedor.Password = txtPassword.Text;
                nuevoVendedor.Direccion = txtDireccion.Text;
                if (nuevoVendedor is Vendedor vendedor)
                {
                    vendedor.CantidadVentas = 0;
                }
                Database.Usuarios.Add(nuevoVendedor);
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool validarCarga()
        {
            if (!(Utilities.validarCajasDeTextoVacias(txtApellido.Text, txtApellido.Text, txtNombreUsuario.Text, txtPassword.Text, txtRepetirPassword.Text)))
            {
                MessageBox.Show("Hay espacios en blanco, ingrese los datos que faltan");
                return false;
            }
            else if (txtPassword.Text != txtRepetirPassword.Text)
            {
                MessageBox.Show("La contraseña que reingreso no coincide con la original, reintente de nuevo.");
                return false;
            }
            foreach (var item in Database.Usuarios)
            {
                if (item.User == txtNombreUsuario.Text)
                {
                    MessageBox.Show("El usuario que quiere registrar no esta disponible. Ingrese otro.");
                    return false;
                }
            }
            return true;
        }
    }
}
