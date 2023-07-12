using BaseDatos;
using Dominio;
using Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class RegistroUsuario : Form
    {
        /* 
         * Esta ventana permite registrar un cliente si el constructor no recibe nada como argumento y si recibe un vendedor
         * crear un nuevo usuario como Vendedor
         */
        private Usuario user = null;
        public RegistroUsuario()
        {
            InitializeComponent();
            Text = "Registrarse";
            this.BackColor = Color.Peru;
        }
        public RegistroUsuario(Vendedor vendedor)
        {
            this.user = vendedor;
            InitializeComponent();
            Text = "Crear nueva cuenta Vendedor";
        }
        // El siguente evento registra el usuario.
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!(validarCarga())) // Valido lo ingresado.
                return;

            if (user == null) // Si el usuario es null, me crea un Cliente
            {
                Usuario nuevoCliente = new Cliente(); // Se crea un nuevo Cliente
                nuevoCliente.ApellidoNombre = txtApellido.Text + ", " + txtNombre.Text;
                nuevoCliente.User = txtNombreUsuario.Text;
                nuevoCliente.Password = txtPassword.Text;
                nuevoCliente.Direccion = txtDireccion.Text;
                nuevoCliente.Telefono = txtTelefono.Text;
                if (nuevoCliente is Cliente cliente)
                {
                    cliente.Mascotas = new List<Mascota>(); // Creo la lista de mascotas para el nuevo Cliente
                    cliente.Pedidos = new List<Pedido>(); // Creo la lista de pedidos para el nuevo Cliente
                }
                Database.Usuarios.Add(nuevoCliente); // Se ingresan los datos y los guardo en la lista de usuarios
                Close();
            }
            else // Si no es null, me registra un vendedor
            {
                Usuario nuevoVendedor = new Vendedor(); // Se crea un nuevo Vendedor
                nuevoVendedor.ApellidoNombre = txtApellido.Text + ", " + txtNombre.Text;
                nuevoVendedor.User = txtNombreUsuario.Text;
                nuevoVendedor.Password = txtPassword.Text;
                nuevoVendedor.Direccion = txtDireccion.Text;
                nuevoVendedor.Telefono = txtTelefono.Text;
                if (nuevoVendedor is Vendedor vendedor)
                {
                    vendedor.CantidadVentas = 0;
                }
                Database.Usuarios.Add(nuevoVendedor); // Se ingresan los datos y los guardo en la lista de usuarios
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool validarCarga()
        {
            // Valido textBoxes si estan vacios.
            if (!(Utilities.validarCajasDeTextoVacias(txtApellido.Text, txtApellido.Text, txtNombreUsuario.Text, txtPassword.Text, txtRepetirPassword.Text, txtDireccion.Text)))
            {
                MessageBox.Show("Hay espacios en blanco, ingrese los datos que faltan");
                return false;
            }
            // Valido se la contraseña que se ingresa primero coincide con la que se ingresa de nuevo.
            if (txtPassword.Text != txtRepetirPassword.Text)
            {
                MessageBox.Show("La contraseña que reingreso no coincide con la original, reintente de nuevo.");
                return false;
            }
            // Busca si existe un nombre de usuario igual al que se quiere registrar. Si es asi, no me permite registrarlo.
            foreach (var item in Database.Usuarios)
            {
                if (item.User == txtNombreUsuario.Text)
                {
                    MessageBox.Show("El usuario que quiere registrar no esta disponible. Ingrese otro.");
                    return false;
                }
            }
            // Valida si el número de teléfono tiene entre 6 y 10 caracteres.
            if (txtTelefono.TextLength < 6 || txtTelefono.TextLength > 10)
            {
                MessageBox.Show("El número de teléfono debe ser válido. Debe contener entre 6 y 10 caracteres.");
                return false;
            }
            return true;
        }
        // Me permite solo escribir números en la caja de texto del teléfono.
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
