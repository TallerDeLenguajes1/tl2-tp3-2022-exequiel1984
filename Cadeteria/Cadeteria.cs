namespace Practico3
{
    public class Cadeteria
    {
        private string nombre;
        private string telefono;
        list<Cadete> listadoCadetes;

        public Cadeteria(list<Cadete> listadoCadetes, string nombre, string telefono)
        {
            ListadoCadetes = listadoCadetes;
            Nombre = nombre;
            Telefono = telefono;
        }

        public list<Cadete> ListadoCadetes { get => listadoCadetes; set => listadoCadetes = value; }
        protected string Nombre { get => nombre; set => nombre = value; }
        protected string Telefono { get => telefono; set => telefono = value; }
    }
}