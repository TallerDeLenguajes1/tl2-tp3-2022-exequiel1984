using System.IO;
using System.Linq; 

namespace Practico3
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Pedidos> PedidosDelDia = new List<Pedidos>();


            DirectorioCadeteria directorioCadeteria = new DirectorioCadeteria();
            Cadeteria NuevaCadeteria = directorioCadeteria.CargarDatosCadeteria();

            DirectorioCadetes directorioCadetes = new DirectorioCadetes();
            directorioCadetes.CargarListaCadetesDesdeCSV(NuevaCadeteria.ListadoCadetes);
            

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
                foreach (var Cadete in NuevaCadeteria.ListadoCadetes)
                {
                        Console.WriteLine($"\nCadete Id: {Cadete.Id}\nNombre cadete: {Cadete.Nombre}\n");
                }
                
                Console.WriteLine("Ingrese el Id del cadete a tomar el pedido:");
                int IdCadeteATomarPedido = Convert.ToInt32(Console.ReadLine());
                        
                foreach (var Pedido in PedidosDelDia)
                {
                    if (Pedido.Nro == NumeroDePedidoAAsignar)
                    {
                        foreach (var Cadete in NuevaCadeteria.ListadoCadetes)
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
            


            /* Console.WriteLine("CAMBIAR PEDIDO DE CADETE");
            Console.WriteLine("Ingrese el Id del cadete al cual le removera el pedido:");
            int IdCadeteARemoverPedido = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el Nro del pedido a cambiar de cadete:");
            int NroPedidoACambiarCadete = Convert.ToInt32(Console.ReadLine());
            Pedidos PedidoAuxiliar = new Pedidos();
            foreach (var Cadete in NuevaCadeteria.ListadoCadetes)
            {
                if (Cadete.Id == IdCadeteARemoverPedido)
                {
                    foreach (var Pedido in Cadete.ListadoPedidosCadete)
                    {
                        if (Pedido.Nro == NroPedidoACambiarCadete)
                        {
                            PedidoAuxiliar = Pedido;
                        }
                    }
                    Cadete.ListadoPedidosCadete.Remove(PedidoAuxiliar);
                }
            }
            Console.WriteLine("Ingrese el Id del cadete al reasignara el pedido:");
            int IdCadeteAReasignarPedido = Convert.ToInt32(Console.ReadLine());
            foreach (var Cadete in NuevaCadeteria.ListadoCadetes)
            {
                if (Cadete.Id == IdCadeteAReasignarPedido)
                {
                    Cadete.ListadoPedidosCadete.Add(PedidoAuxiliar);
                }
            } */
 


            Console.WriteLine("CAMBIAR ESTADO DE PEDIDO");
            int NroPedidoACambiarEstado = 0;
            string ConsultaCambiarEstado = "si";

            do
            {
                Console.WriteLine("Ingrese el numero de pedido a cambiar estado:");
                NroPedidoACambiarEstado = Convert.ToInt32(Console.ReadLine());
                foreach (var Pedido in PedidosDelDia)
                {
                    if (Pedido.Nro == NroPedidoACambiarEstado)
                    {
                        Pedido.Estado = "Entregado";
                    }
                }

                Console.WriteLine("¿Desea cambiar el estado de otro pedido?");
                ConsultaCambiarEstado = Console.ReadLine();
            } while (ConsultaCambiarEstado == "si");
            


            



            Console.WriteLine("\nCONTROL");
            foreach (var Cadete in NuevaCadeteria.ListadoCadetes)
            {
                Console.WriteLine($"\nCADETE NOMBRE: {Cadete.Nombre.ToUpper()}" );
                foreach (var Pedido in Cadete.ListadoPedidosCadete)
                {
                    Console.WriteLine($"Pedido numero: {Pedido.Nro}" );
                    Console.WriteLine($"Pedido nombre cliente: {Pedido.ClientePedido.Nombre}\n" );
                }
            }

            Console.WriteLine("\nPEDIDOS DEL DIA");
            foreach (var Pedido in PedidosDelDia)
            {
                Console.WriteLine($"Pedido numero: {Pedido.Nro}" );
                Console.WriteLine($"Pedido nombre cliente: {Pedido.ClientePedido.Nombre}" );
                Console.WriteLine($"Pedido estado: {Pedido.Estado}\n" );
            }

            Console.WriteLine("\nMONTO GANADO POR CADA CADETE");

            

            foreach (var empleado in NuevaCadeteria.ListadoCadetes)
            {
                float Jornal = 0;
                foreach (var pedido in empleado.ListadoPedidosCadete)
                {
                    if (pedido.Estado == "Entregado")
                    {
                        Jornal += 300;
                    }
                }
                Console.WriteLine($"Monto ganado por {empleado.Nombre} es ${Jornal}");
            }
            

        }

        
    }
}