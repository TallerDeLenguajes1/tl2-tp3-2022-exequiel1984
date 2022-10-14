namespace Practico3
{
    public class Cadete : Persona
    {
        private List<Pedidos> listadoPedidosCadete;

        public List<Pedidos> ListadoPedidosCadete { get => listadoPedidosCadete; set => listadoPedidosCadete = value; }

        public Cadete () : base() 
        {

        }

        public Cadete(string[] datosCadeteCSV)
        {
            this.Id = Convert.ToInt32(datosCadeteCSV[0]);
            this.Nombre = datosCadeteCSV[1];
            this.Direccion = datosCadeteCSV[2];
            this.Telefono = datosCadeteCSV[3];
            this.ListadoPedidosCadete = new List<Pedidos>();
        }

        /* public float JornalACobrar ()
        {
            float Jornal = ListadoPedidosCadete.Where(pedido => ListadoPedidosCadete.Pedidos.Estado == "Entregado").Sum(300);
            return Jornal;
        } */
    }
}