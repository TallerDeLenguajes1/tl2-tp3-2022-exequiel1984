namespace Practico3
{
    public class CrearCadeteria
    {
        public static Cadeteria CargarDatosCadeteria(string ArchivoCSV)
        {
            var LeerArchivoCSV = File.ReadAllLines(ArchivoCSV);
            var LineaCSV = (LeerArchivoCSV[0]).Split(",");
            Cadeteria NuevaCadeteria = new Cadeteria();
            
            NuevaCadeteria.Nombre = LineaCSV[0];
            NuevaCadeteria.Telefono = LineaCSV[1];

            return NuevaCadeteria;       
        }
    }
}