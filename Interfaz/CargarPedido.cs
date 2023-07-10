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
    public partial class CargarPedido : Form
    {
        private Cliente user;
        private float cantidadAlimentos;
        private int cantidadComplementos;
        public CargarPedido(Cliente user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void CargarPedido_Load(object sender, EventArgs e)
        {
            txtCodigoPedido.Text = Utilities.asignarCodigoPedido();
            dtpFecha.Value = DateTime.Now;
            cboVendedor.DataSource = Utilities.cargarVendedores();
            cboMascota.DataSource = user.Mascotas;
            cboVendedor.SelectedIndex = -1;
            cboMascota.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cboMascota.SelectedItem is Mascota mascota)
            {
                calculoSegunMascota(mascota);
                txtDetallePedido.Lines = new string[]
                {
                    "Detalles del pedido:",
                    "Nombre de la mascota: " + mascota.Nombre,
                    "Cantidad Alimento: " + cantidadAlimentos + " kg",
                    "Cantidad de Complementos dietarios: " + cantidadComplementos
                };
            }
        }

        private void btnPedir_Click(object sender, EventArgs e)
        {
            if (!(validarPedido()))
                return;
            
            Pedido nuevoPedido = new Pedido();

            nuevoPedido.CodigoPedido = int.Parse(txtCodigoPedido.Text);
            nuevoPedido.Cliente = user.ApellidoNombre;
            nuevoPedido.Fecha = DateTime.Now;
            nuevoPedido.Vendedor = cboVendedor.SelectedValue.ToString();
            Utilities.agregarVentaVendedor(nuevoPedido.Vendedor);
            nuevoPedido.CantidadPorKg = cantidadAlimentos;
            nuevoPedido.ComplementosDietarios = cantidadComplementos;
            nuevoPedido.Estado = "Recibido";
            user.Pedidos.Add(nuevoPedido);

            MessageBox.Show("Pedido cargado con éxito");
            Close();
        }
        private void calculoSegunMascota(Mascota mascota)
        {
            int i = 3;
            cantidadAlimentos = 0;
            cantidadComplementos = 0;
            if (mascota.Tipo == "Perro")
            {
                cantidadAlimentos = mascota.Peso * 0.8f;
                while (mascota.Edad >= i)
                {
                    cantidadComplementos++;
                    i += 3;
                }
                if (mascota.EstaCastrado && mascota.Edad > 5)
                    cantidadComplementos++;
            }
            else
            {
                cantidadAlimentos = mascota.Peso * 0.5f;
                if (mascota.Edad > 5)
                    cantidadComplementos++;
                if (mascota.EstaCastrado)
                    cantidadComplementos++;
            }
        }
        public bool validarPedido()
        {
            if (string.IsNullOrEmpty(cboMascota.Text) || string.IsNullOrEmpty(cboVendedor.Text))
            {
                MessageBox.Show("Hay datos no ingreso, verifique nuevamente.");
                return false;
            }
            return true;
        }
    }
}
