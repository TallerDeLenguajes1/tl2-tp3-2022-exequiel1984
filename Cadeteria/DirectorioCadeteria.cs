namespace Practico3
{
    public class DirectorioCadeteria
    {
        public static Cadeteria CargarDatosCadeteria(string ArchivoCSV)
        {
            var LeerArchivoCSV = File.ReadAllLines(ArchivoCSV);
            var LineaCSV = (LeerArchivoCSV[0]).Split(",");
            Cadeteria NuevaCadeteria = new Cadeteria(LineaCSV[0], LineaCSV[1]);
            
            NuevaCadeteria.Nombre = LineaCSV[0];
            NuevaCadeteria.Telefono = LineaCSV[1];

            return NuevaCadeteria;       
        }
    }
}