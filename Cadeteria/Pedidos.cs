namespace Practico3
{
    public class Pedidos
    {
        private int nro;
        private string obs;
        private Cliente clientePedido;
        private string estado;

        protected int Nro { get => nro; set => nro = value; }
        protected string Obs { get => obs; set => obs = value; }
        protected Cliente ClientePedido { get => clientePedido; set => clientePedido = value; }
        protected string Estado { get => estado; set => estado = value; }

        public Pedidos () {

        }

        public Pedidos(int nroPedido, string obsPedido, Cliente costumerPedido, string estadoPedido)
        {
            this.Nro = nroPedido;
            this.Obs = obsPedido;
            this.ClientePedido = costumerPedido;
            this.Estado = estadoPedido;
        }
    }
}