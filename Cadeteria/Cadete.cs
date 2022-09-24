namespace Practico3
{
    public class Cadete : Persona
    {
        list<Pedidos> listadoPedidosCadete;

        public list<Pedidos> ListadoPedidosCadete { get => listadoPedidosCadete; set => listadoPedidosCadete = value; }

        public Cadete () {}

        public Cadete(list<Pedidos> listadoPedidosCadete)
        {
            ListadoPedidosCadete = listadoPedidosCadete;
        }

        public void JornalACobrar (list<Pedidos> ListadoPedidos)
        {
            int Jornal = ListadoPedidos.Where(pedido => ListadoPedidos.Estado == Entredado).Sum(300);
            System.Console.WriteLine(Jornal);
        }
    }
}