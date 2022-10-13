
using System.IO;
using System.Net;
using System.Text.Json;

namespace Practico3
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Cadete> ListadoCadetes = new List<Cadete>();
            List<Pedidos> PedidosSinAsignar = new List<Pedidos>();

            Cadeteria Cadeteria = CrearCadeteria.CargarDatosCadeteria("DatosCadeteria.csv");

            MetodosCadetes.CargarListaCadetesDesdeCSV(ListadoCadetes, "DatosCadetes.csv");
            
            Pedidos NuevoPedido = MetodosPedidos.CrearPedido();

            PedidosSinAsignar.Add(NuevoPedido);




            foreach (var Pedido in PedidosSinAsignar)
            {
                Console.WriteLine("\nCONTROL");
                Console.WriteLine(Pedido.ClientePedido.Nombre);
            }

        }

        
    }
}