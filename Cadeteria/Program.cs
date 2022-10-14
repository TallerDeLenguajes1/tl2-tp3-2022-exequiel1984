
using System.IO;
using System.Net;
using System.Text.Json;

namespace Practico3
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Pedidos> PedidosDelDia = new List<Pedidos>();

            Cadeteria NuevaCadeteria = CrearCadeteria.CargarDatosCadeteria("DatosCadeteria.csv");

            MetodosCadetes metodosCadetes = new MetodosCadetes();

            metodosCadetes.CargarListaCadetesDesdeCSV(NuevaCadeteria.ListadoCadetes, "DatosCadetes.csv");
            
            string ConsultaIngresarNuevoPedido = "si";
            int NumeroPedido = 1;
            
            Console.WriteLine("TOMAR PEDIDO");
            do
            {
                Pedidos NuevoPedido = MetodosPedidos.CrearPedido(NumeroPedido);
                PedidosDelDia.Add(NuevoPedido);
                NumeroPedido++;
                Console.WriteLine("¿Desea ingresar un nuevo pedido? (si/no)");
                ConsultaIngresarNuevoPedido = Console.ReadLine();
            } while (ConsultaIngresarNuevoPedido == "si");



            Console.WriteLine("\nASIGNAR PEDIDOS A CADETES");

            int CantidadPedidosSinAsignar = 0;

            foreach (var Pedido in PedidosDelDia)
                {
                    if (Pedido.Estado == "Sin asignar")
                    {
                        CantidadPedidosSinAsignar++;
                    }
                }

            do
            {
                Console.WriteLine($"Cantidad de pedidos sin asignar: {CantidadPedidosSinAsignar}");

                Console.WriteLine("\nLISTA DE PEDIDOS SIN ASIGNAR");
                foreach (var Pedido in PedidosDelDia)
                {    
                    if (Pedido.Estado == "Sin asignar")
                    {
                        Console.WriteLine($"\nPedido numero: {Pedido.Nro}\nCliente: {Pedido.ClientePedido.Nombre}");
                    }
                }
                Console.WriteLine("\nIngrese el numero de pedido a asignar:");
                int NumeroDePedidoAAsignar = Convert.ToInt32(Console.ReadLine());       
                
                Console.WriteLine($"\nLISTADO DE CADETES");
                foreach (var Cadete in ListadoCadetes)
                {
                        Console.WriteLine($"\nCadete Id: {Cadete.Id}\nNombre cadete: {Cadete.Nombre}\n");
                }
                
                Console.WriteLine("Ingrese el Id del cadete a tomar el pedido:");
                int IdCadeteATomarPedido = Convert.ToInt32(Console.ReadLine());
                        
                foreach (var Pedido in PedidosDelDia)
                {
                    if (Pedido.Nro == NumeroDePedidoAAsignar)
                    {
                        foreach (var Cadete in ListadoCadetes)
                        {
                            if (Cadete.Id == IdCadeteATomarPedido)
                            {
                                Cadete.ListadoPedidosCadete.Add(Pedido); 
                            }
                        }
                        Pedido.Estado = "Asignado";
                    }
                }

            CantidadPedidosSinAsignar--;
            } while (CantidadPedidosSinAsignar > 0);
            




            Console.WriteLine("\nCONTROL");
            foreach (var Cadete in ListadoCadetes)
            {
                Console.WriteLine($"\nNombre cadete: {Cadete.Nombre}" );
                foreach (var Pedido in Cadete.ListadoPedidosCadete)
                {
                    Console.WriteLine($"Numero pedido: {Pedido.Nro}" );
                    Console.WriteLine($"Nombre cliente pedido: {Pedido.ClientePedido.Nombre}\n" );
                }
            }

            Console.WriteLine("\nPEDIDOS DEL DIA");

            foreach (var Pedido in PedidosDelDia)
            {
                Console.WriteLine($"Numero pedido: {Pedido.Nro}" );
                Console.WriteLine($"Nombre cliente pedido: {Pedido.ClientePedido.Nombre}\n" );
            }

        }

        
    }
}