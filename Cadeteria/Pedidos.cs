namespace Practico3
{
    public class Pedidos
    {
        private int nro;
        private string obs;
        private Cliente clientePedido;
        private string estado;

        public Pedidos () {}

        public Pedidos(int nro, string obs, Cliente clientePedido, string estado)
        {
            Nro = nro;
            Obs = obs;
            ClientePedido = clientePedido;
            Estado = estado;
        }

        protected int Nro { get => nro; set => nro = value; }
        protected string Obs { get => obs; set => obs = value; }
        protected Cliente ClientePedido { get => clientePedido; set => clientePedido = value; }
        protected string Estado { get => estado; set => estado = value; }
    }
}