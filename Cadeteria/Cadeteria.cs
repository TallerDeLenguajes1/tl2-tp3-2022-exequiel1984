namespace Practico3
{
    public class Cadeteria
    {
        private string nombre;
        private string telefono;
        private list<Cadete> listadoCadetes;

        protected string Nombre { get => nombre; set => nombre = value; }
        protected string Telefono { get => telefono; set => telefono = value; }
        public list<Cadete> ListadoCadetes { get => listadoCadetes; set => listadoCadetes = value; }

        public Cadeteria()
        {

        }

        public Cadeteria(string nombreCadeteria, string telefonoCadeteria, list<Cadete> listadoCadetesCadeteria)
        {
            this.Nombre = nombreCadeteria;
            this.Telefono = telefonoCadeteria;
            this.ListadoCadetes = listadoCadetesCadeteria;
        }
    }
}