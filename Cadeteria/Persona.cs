namespace Practico3
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string direccion;
        private string telefono;

        public Persona () {}

        public Persona(int id, string nombre, string direccion, string telefono)
        {
            Id = id;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
        }

        protected int Id { get => id; set => id = value; }
        protected string Nombre { get => nombre; set => nombre = value; }
        protected string Direccion { get => direccion; set => direccion = value; }
        protected string Telefono { get => telefono; set => telefono = value; }
    }
}