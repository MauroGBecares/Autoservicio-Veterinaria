using BaseDatos;
using Dominio;
using System.Collections.Generic;

namespace Helpers
{
    /*
     * En esta clase, es la que se encargar otorgar funciones útiles para facilitar la escritura de código y
     * la idea es poder reutilizar las mismas cuando sea necesario.
    */
    public class Utilities
    {
        /*
         * Los metodos que se encuentra en esta clase son estatico, esto lo que hace que no sea necesario
         * crear un objeto para poder utilizar los mismos.
         * El método validarCajasDeTextoVacias esta sobrecargado para poder recibir 5 o 6 variables de tipo string, 
         * dependiendo la necesidad se utiliza una u otra para validar las cajas de texto o ComboBox.
         */
        public static bool validarCajasDeTextoVacias(string texto1, string texto2, string texto3, string texto4, string texto5)
        {
            if (string.IsNullOrEmpty(texto1) && string.IsNullOrEmpty(texto2) && string.IsNullOrEmpty(texto3) && string.IsNullOrEmpty(texto4) && string.IsNullOrEmpty(texto5))
            {
                return false;
            }
            return true;
        }
        public static bool validarCajasDeTextoVacias(string texto1, string texto2, string texto3, string texto4, string texto5, string texto6)
        {
            if (string.IsNullOrEmpty(texto1) && string.IsNullOrEmpty(texto2) && string.IsNullOrEmpty(texto3) && string.IsNullOrEmpty(texto4) && string.IsNullOrEmpty(texto5) && string.IsNullOrEmpty(texto6))
            {
                return false;
            }
            return true;
        }
        /* 
         * Este método lo que hace es buscar si hay coincidencias entre el usuario que se trajo con el
         * que hay en la base de datos. Devuelve un objeto Usuario que luego sirva para compararlo a la hora
         * de iniciar sesion.
         */
        public static Usuario buscarUsuario(string user)
        {
            foreach (var item in Database.Usuarios)
            {
                if (item.User == user)
                {
                    return item;
                }
            }
            return null;
        }
        /* 
         * Este método busca si hay coincidencia entre la contraseña que ingreso el usuario con la que esta
         * guardada en la base de datos
         */
        public static bool validarPassword(Usuario user, string pass)
        {
            foreach (var item in Database.Usuarios)
            {
                if (item == user)
                {
                    if (item.Password == pass)
                        return true;
                }
            }
            return false;
        }
        /* 
         * Lo que hace este método es buscar un nuevo número si hay disponible para asignarle al 
         * código del pedido nuevo. Yo hice que busque a partir del 100 hasta que encuentre uno y ese se asignará
         */
        public static string asignarCodigoPedido()
        {
            int buscarCodigo = 100;

            while (true)
            {
                bool encontrado = false;

                foreach (Usuario usuario in Database.Usuarios)
                {
                    if (usuario is Cliente cliente)
                    {
                        foreach (Pedido pedido in cliente.Pedidos)
                        {
                            if (pedido.CodigoPedido == buscarCodigo)
                            {
                                encontrado = true;
                                break;
                            }
                        }
                    }
                    if (encontrado)
                        break;
                }

                if (!encontrado)
                {
                    return buscarCodigo.ToString();
                }

                buscarCodigo++;
            }
        }
        /* 
         * Este método lo que hace es cargar los vendedores que hay en la base de datos. Se utilizo tanto para
         * un ComboBox como tambien para un DataGridView
         */
        public static List<Vendedor> cargarVendedores()
        {
            List<Vendedor> listaVendedores = new List<Vendedor>();
            foreach (var item in Database.Usuarios)
            {
                if (item is Vendedor vendedor)
                {
                    listaVendedores.Add(vendedor);
                }
            }
            return listaVendedores;
        }
        /*
         * Este método es similar al anterior pero esta vez carga los clientes
         */
        public static List<Cliente> cargarClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            foreach (var item in Database.Usuarios)
            {
                if (item is Cliente cliente)
                {
                    listaClientes.Add(cliente);
                }
            }
            return listaClientes;
        }
        /*
         * Este método recibo un nombre de vendedor y devuelve las ventas que son del mismo.
         */
        public static List<Pedido> cargarPedidosSegunVendedor(string nombreVendedor)
        {
            List<Pedido> listaPedidos = new List<Pedido>();
            foreach (Usuario usuario in Database.Usuarios)
            {
                if (usuario is Cliente cliente)
                {
                    foreach (Pedido pedido in cliente.Pedidos)
                    {
                        if (pedido.Vendedor == nombreVendedor)
                            listaPedidos.Add(pedido);
                    }
                }
            }
            return listaPedidos;
        }
        /* 
         * Este método agrega una venta a un vendedor según el nombre recibido a la base de datos.
         */
        public static void agregarVentaVendedor(string nombreVendedor)
        {
            foreach (Usuario usuario in Database.Usuarios)
            {
                if (usuario is Vendedor vendedor)
                {
                    if (vendedor.ApellidoNombre == nombreVendedor)
                        vendedor.CantidadVentas++;
                }
            }
        }
       /* 
        * Similar al anterior pero resta la venta.
        */
        public static void eliminarVentaVendedor(string nombreVendedor)
        {
            foreach (Usuario usuario in Database.Usuarios)
            {
                if (usuario is Vendedor vendedor)
                {
                    if (vendedor.ApellidoNombre == nombreVendedor)
                        vendedor.CantidadVentas--;
                }
            }
        }
    }
}
