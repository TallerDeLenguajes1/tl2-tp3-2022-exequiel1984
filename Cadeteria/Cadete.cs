namespace Practico3
{
    public class Cadete : Persona
    {
        private List<Pedidos> listadoPedidosCadete;

        public List<Pedidos> ListadoPedidosCadete { get => listadoPedidosCadete; set => listadoPedidosCadete = value; }

        public Cadete () : base() 
        {

        }

        public Cadete(int idCadete, string[] datosCadeteCSV)
        {
            this.Id = idCadete;
            this.Nombre = datosCadeteCSV[0];
            this.Direccion = datosCadeteCSV[1];
            this.Telefono = datosCadeteCSV[2];
            this.ListadoPedidosCadete = new List<Pedidos>();
        }

        /* public float JornalACobrar ()
        {
            float Jornal = ListadoPedidosCadete.Where(pedido => ListadoPedidosCadete.Pedidos.Estado == "Entregado").Sum(300);
            return Jornal;
        } */
    }
}