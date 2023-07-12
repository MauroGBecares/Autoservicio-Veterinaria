using Dominio;
using Helpers;
using System;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class CargarPedido : Form
    {
        private Cliente user; // Asigno el atributo de tipo cliente segun lo que reciba el constructor y esto me permite multiples usos
        /*
         *  Tanto cantidadAlimentos como cantidadComplementos se utilizan para que al alojar los datos alli que permanecen en un espacio de memoria especifico
         *  me permite utilizarlo en otros eventos o métodos.
         */
        private float cantidadAlimentos;  
        private int cantidadComplementos;
        public CargarPedido(Cliente user)
        {
            this.user = user; 
            InitializeComponent();
        }

        private void CargarPedido_Load(object sender, EventArgs e)
        {
            txtCodigoPedido.Text = Utilities.asignarCodigoPedido(); // Asigna un nùmero de pedido utilizando una funcion de la clase Utilities
            dtpFecha.Value = DateTime.Now; //Asigna la fecha de hoy y la hora actual.
            cboVendedor.DataSource = Utilities.cargarVendedores(); //Carga todos los vendedores que hay en un ComboBox
            cboMascota.DataSource = user.Mascotas; //Carga las mascotas que tiene el Cliente
            cboVendedor.SelectedIndex = -1; //Esto se utilizo por temas de diseño. Para que al cargar la ventana, no haya datos cargados en el ComboBox
            cboMascota.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close(); //Cierra la ventana
        }
        // El siguiente evento actua cuando selecciono un item diferente en el ComboBox
        private void cboMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si lo seleccionado es una mascota, me muestra una mascota.
            if (cboMascota.SelectedItem is Mascota mascota)
            {
                calculoSegunMascota(mascota); // Esta funcion realiza los calculos para luego mostrarlos en los detalles.
                txtDetallePedido.Lines = new string[] // Muestra el detalle del pedido segun lo que se quiere pedir
                {
                    "Detalles del pedido:",
                    "Nombre de la mascota: " + mascota.Nombre,
                    "Cantidad Alimento: " + cantidadAlimentos + " kg",
                    "Cantidad de Complementos dietarios: " + cantidadComplementos
                };
            }
            else
            {
                txtDetallePedido.Clear(); // Esto esta puesto por temas de diseño, ya que sino me carga datos al cargar la ventana.
            }
        }
        // Lo siguiente ejecuta la accion de pedir
        private void btnPedir_Click(object sender, EventArgs e)
        {
            if (!(validarPedido())) // Realiza la validacion y corta la ejecucion dependiendo lo que devuelva.
                return;

            Pedido nuevoPedido = new Pedido(); // Creo un nuevo objeto Pedido

            nuevoPedido.CodigoPedido = int.Parse(txtCodigoPedido.Text); 
            nuevoPedido.Cliente = user.ApellidoNombre;
            nuevoPedido.Fecha = DateTime.Now;
            nuevoPedido.Vendedor = cboVendedor.SelectedValue.ToString();
            Utilities.agregarVentaVendedor(nuevoPedido.Vendedor);
            nuevoPedido.CantidadPorKg = cantidadAlimentos;
            nuevoPedido.ComplementosDietarios = cantidadComplementos;
            nuevoPedido.Estado = "Recibido";
            user.Pedidos.Add(nuevoPedido); //Asigno los datos y los guardo en una lista de pedidos que tiene el usuario

            MessageBox.Show("Pedido cargado con éxito");
            Close();
        }
        /*
         * En el siguiente método realizo el calculo:
         * Para gatos:
         * ● Cantidad de alimento igual a 0.5 veces su peso.
         * ● Un complemento dietario si el gato tiene más de 5 años.
         * ● Un complemento dietario extra si el gato está castrado.
         * Para perros:
         * ● Cantidad de alimento igual a 0.8 veces su peso.
         * ● Un complemento dietario por cada 3 años edad.
         * ● Un complemento dietario extra si el perro está castrado y tiene más de 5 años.
         */
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
        // Con esto valido si hay ComboBoxes sin datos ingresados.
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
