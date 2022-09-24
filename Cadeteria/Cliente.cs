namespace Practico3
{
    public class Cliente : Persona
    {
        private string datosReferenciaDireccion;

        protected string DatosReferenciaDireccion { get => datosReferenciaDireccion; set => datosReferenciaDireccion = value; }

        public Cliente () {}

        public Cliente(string datosReferenciaDireccion)
        {
            DatosReferenciaDireccion = datosReferenciaDireccion;
        }
    }
}