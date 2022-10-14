namespace Practico3
{
    public class Cadeteria
    {
        private string nombre;
        private string telefono;
        private List<Cadete> listadoCadetes = new List<Cadete>();

        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public List<Cadete> ListadoCadetes { get => listadoCadetes; set => listadoCadetes = value; }

        public Cadeteria(string nombreCadeteria, string telefonoCadeteria)
        {
            this.Nombre = nombreCadeteria;
            this.Telefono = telefonoCadeteria;
            this.ListadoCadetes = listadoCadetes;
        }
    }
}