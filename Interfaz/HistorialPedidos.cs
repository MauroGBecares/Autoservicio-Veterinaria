using Dominio;
using Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class HistorialPedidos : Form
    {
        private Usuario user;
        private List<Pedido> listaPedidos;
        /* 
         * En los siguientes constructores la ventana se generará de una manera u otra dependiendo del usuario que
         * haya ingresado.
         */
        public HistorialPedidos(Cliente userCliente)
        {
            this.user = userCliente;
            InitializeComponent();
            btnMarcarDespachado.Visible = false;
            this.BackColor = Color.SeaGreen;
            dgvListadoPedidos.BackgroundColor = Color.BurlyWood;
        }
        public HistorialPedidos(Vendedor userVendedor)
        {
            this.user = userVendedor;
            InitializeComponent();
            btnCancelarPedido.Visible = false;
        }

        private void HistorialPedidos_Load(object sender, EventArgs e)
        {
            cargar(); // Al cargar la ventana, me actualiza el listado. 
        }
        /* 
         * El siguiente evento solo esta disponible para el Cliente y en el mismo podrá cancelar el pedido que realizó.
         * Si el pedido ya fue despachado no podrá cancelarlo.
         */
        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            if (dgvListadoPedidos.CurrentRow != null)
            {
                Pedido seleccionado = (Pedido)dgvListadoPedidos.CurrentRow.DataBoundItem;
                if (!(seleccionado.Estado == "Despachado"))
                {
                    DialogResult resultado = MessageBox.Show("Esta seguro que quiere cancelar el pedido?", "Cancelando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        if (user is Cliente cliente)
                        {
                            Utilities.eliminarVentaVendedor(seleccionado.Vendedor);
                            cliente.Pedidos.Remove(seleccionado);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No puede cancelar un pedido que ya fue despachado. Espere que reciba el mismo a su domicilio para que pueda realizar la devolución.");
                }
                cargar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un pedido.");
            }
        }       
         // El siguiente botón marca como despachado el pedido seleccionado. Solo disponible para usuario Vendedor.         
        private void btnMarcarDespachado_Click(object sender, EventArgs e)
        {
            if (dgvListadoPedidos.CurrentRow != null)
            {
                Pedido seleccionado = (Pedido)dgvListadoPedidos.CurrentRow.DataBoundItem;
                DialogResult resultado = MessageBox.Show("Marcar como despachado?", "Despachando", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    seleccionado.Estado = "Despachado";
                }
                cargar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un pedido.");
            }
        }
        // Lo que hace cargar() es actualizar la lista de pedidos segun el usuario es vendedor o cliente.
        public void cargar()
        {
            if (user is Cliente cliente)
            {
                dgvListadoPedidos.DataSource = null;
                dgvListadoPedidos.DataSource = cliente.Pedidos;
                dgvListadoPedidos.Columns["Estado"].Visible = false; // Esta opcion solo lo puede ver el vendedor
                dgvListadoPedidos.Columns["Cliente"].Visible = false;
            }
            else
            {
                // Utilizo el método cargarPedidosSegunVendedor para que solo muestre los pedidos según el vendedor que ingreso.
                listaPedidos = Utilities.cargarPedidosSegunVendedor(user.ApellidoNombre);
                dgvListadoPedidos.DataSource = null;
                dgvListadoPedidos.DataSource = listaPedidos;
            }
        }
    }
}
