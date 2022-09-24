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
    }
}