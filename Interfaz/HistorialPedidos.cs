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
    public partial class HistorialPedidos : Form
    {
        private Usuario user;
        private List<Pedido> listaPedidos;
        public HistorialPedidos(Cliente userCliente)
        {
            this.user = userCliente;
            InitializeComponent();
            btnMarcarDespachado.Visible = false;
        }
        public HistorialPedidos(Vendedor userVendedor)
        {
            this.user = userVendedor;
            InitializeComponent();
            btnCancelarPedido.Visible = false;
        }

        private void HistorialPedidos_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
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

        private void btnMarcarDespachado_Click(object sender, EventArgs e)
        {
            Pedido seleccionado = (Pedido)dgvListadoPedidos.CurrentRow.DataBoundItem;
            DialogResult resultado = MessageBox.Show("Marcar como despachado?", "Despachando", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                seleccionado.Estado = "Despachado";
            }
            cargar();
        }
        public void cargar()
        {
            if (user is Cliente cliente)
            {
                dgvListadoPedidos.DataSource = null;
                dgvListadoPedidos.DataSource = cliente.Pedidos;
                dgvListadoPedidos.Columns["Estado"].Visible = false;
                dgvListadoPedidos.Columns["Cliente"].Visible = false;
            }
            else
            {
                listaPedidos = Utilities.cargarPedidosSegunVendedor(user.ApellidoNombre);
                dgvListadoPedidos.DataSource = null;
                dgvListadoPedidos.DataSource = listaPedidos;
            }
        }
    }
}
