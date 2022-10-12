using Linq;

namespace Practico3
{
    public class Cadete : Persona
    {
        private list<Pedidos> listadoPedidosCadete;

        public list<Pedidos> ListadoPedidosCadete { get => listadoPedidosCadete; set => listadoPedidosCadete = value; }

        public Cadete () : base() 
        {

        }

        public Cadete(int idCadete, string nombreCadete, string direccionCadete, string telefonoCadete)
        {
            this.Id = idCadete;
            this.Nombre = nombreCadete;
            this.Direccion = direccionCadete;
            this.Telefono = telefonoCadete;
            this.ListadoPedidosCadete = new list<Pedidos>();
        }

        public float JornalACobrar ()
        {
            float Jornal = ListadoPedidosCadete.Where(pedido => ListadoPedidos.Estado == Entregado).Sum(300);
            return Jornal;
        }
    }
}