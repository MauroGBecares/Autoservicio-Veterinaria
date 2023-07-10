using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public static class Database
    {   
        public static List<Usuario> Usuarios { get; set; }

        static Database()
        {
            Usuarios = new List<Usuario>();
        }
        public static void HardcodearBaseDeDatos()
        {
            Cliente cliente1 = new Cliente
            {
                User = "Pedro123",
                Password = "123",
                ApellidoNombre = "Pérez, Pedro",
                Direccion = "Av. San Martin 564",
                Mascotas = new List<Mascota>
                {
                    new Mascota
                    {
                        Nombre = "Luna",
                        Tipo = "Perro",
                        Sexo = "Hembra",
                        Peso = 10f,
                        Edad = 3,
                        EstaCastrado = false
                    },
                    new Mascota
                    {
                        Nombre = "Max",
                        Tipo = "Gato",
                        Peso = 6.2f,
                        Sexo = "Macho",
                        Edad = 2,
                        EstaCastrado = true
                    }
                },
                Pedidos = new List<Pedido>
                {
                    new Pedido
                    {
                        CodigoPedido = 102,
                        Cliente = "Pérez, Pedro",
                        Fecha = new DateTime(2023,01,02,11,30,10),
                        Vendedor = "Ramírez, Pedro",
                        CantidadPorKg = 8,
                        ComplementosDietarios = 1,
                        Estado = "Recibido"
                    }
                }
            };

            Cliente cliente2 = new Cliente
            {
                User = "maria64",
                Password = "456",
                ApellidoNombre = "González, María",
                Direccion = "Colombia 3546",
                Mascotas = new List<Mascota>
                {
                    new Mascota
                    {
                        Nombre = "Simba",
                        Tipo = "Gato",
                        Sexo = "Macho",
                        Peso = 5.2f,
                        Edad = 2,
                        EstaCastrado = true
                    }
                },
                Pedidos = new List<Pedido>
                {
                    new Pedido
                    {
                        CodigoPedido = 100,
                        Cliente = "González, María",
                        Fecha = new DateTime(2023,12,11,15,55,45),
                        Vendedor = "López, Ana",
                        CantidadPorKg = 2.6f,
                        ComplementosDietarios = 1,
                        Estado = "Despachado"
                    },
                    new Pedido
                    {
                        CodigoPedido = 101,
                        Cliente = "González, María",
                        Fecha = new DateTime(2023,10,23,18,55,35),
                        Vendedor = "Ramírez, Pedro",
                        CantidadPorKg = 2.6f,
                        ComplementosDietarios = 1,
                        Estado = "Recibido"
                    }
                }
            };

            Usuarios.Add(cliente1);
            Usuarios.Add(cliente2);
            

            Vendedor vendedor1 = new Vendedor
            {
                User = "ana25",
                Password = "789",
                ApellidoNombre = "López, Ana",
                Direccion = "Bv. Avellaneda 3354",
                CantidadVentas = 1
            };

            Vendedor vendedor2 = new Vendedor
            {
                User = "rpedro68",
                Password = "8564",
                ApellidoNombre = "Ramírez, Pedro",
                Direccion = "Ov. Lagos 631",
                CantidadVentas = 2
            };

            Usuarios.Add(vendedor1);
            Usuarios.Add(vendedor2);
        }
    }
}

