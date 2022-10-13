namespace Practico3
{
    public class Cliente : Persona
    {
        private string datosReferenciaDireccion;

        public string DatosReferenciaDireccion { get => datosReferenciaDireccion; set => datosReferenciaDireccion = value; }

        public Cliente() : base() 
        {

        }

        public Cliente(int idCliente, string nombreCliente, string direccionCliente, string telefonoCliente, string datosReferenciaDireccionCliente)
        {
            this.Id = idCliente;
            this.Nombre = nombreCliente;
            this.Direccion = direccionCliente;
            this.Telefono = telefonoCliente;
            this.DatosReferenciaDireccion = datosReferenciaDireccionCliente;
        }
    }
}