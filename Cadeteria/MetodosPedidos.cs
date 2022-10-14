namespace Practico3
{
    public class MetodosPedidos
    {
        public static Pedidos CrearPedido(int Numero)
        {
            
            Pedidos NuevoPedido = new Pedidos();
            Cliente NuevoCliente = new Cliente();

            NuevoPedido.ClientePedido = NuevoCliente;

            NuevoPedido.Nro = Numero;
            Console.WriteLine("Ingrese el nombre del cliente:");
            NuevoPedido.ClientePedido.Nombre = Console.ReadLine();
            /* Console.WriteLine("Ingrese la direccion del cliente:");
            NuevoPedido.ClientePedido.Direccion = Console.ReadLine();
            Console.WriteLine("Ingrese el telefono del cliente:");
            NuevoPedido.ClientePedido.Telefono = Console.ReadLine();
            Console.WriteLine("Ingrese datos de referencia de la direccion del cliente:");
            NuevoPedido.ClientePedido.DatosReferenciaDireccion = Console.ReadLine();
            Console.WriteLine("Ingrese alguna observacion al pedido:");
            NuevoPedido.Obs = Console.ReadLine(); */
            NuevoPedido.Estado = "Sin asignar";
            
            return NuevoPedido;
        }
    }
}