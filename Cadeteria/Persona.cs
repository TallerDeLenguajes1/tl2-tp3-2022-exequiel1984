namespace Practico3
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string direccion;
        private string telefono;

        protected int Id { get => id; set => id = value; }
        protected string Nombre { get => nombre; set => nombre = value; }
        protected string Direccion { get => direccion; set => direccion = value; }
        protected string Telefono { get => telefono; set => telefono = value; }

        public Persona () 
        {

        }
    }
}