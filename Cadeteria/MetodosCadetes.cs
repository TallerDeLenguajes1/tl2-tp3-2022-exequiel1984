namespace Practico3
{
    public class MetodosCadetes
    {
        public static void CargarListaCadetesDesdeCSV(List<Cadete> ListadoCadetes, string ArchivoCSV)
        {
            var LeerArchivoCSV = File.ReadAllLines(ArchivoCSV);

            for (int i = 0; i < LeerArchivoCSV.Length; i++)
            {
                var LineaCSV = (LeerArchivoCSV[i]).Split(",");
                Cadete NuevoCadete = new Cadete(i+1, LineaCSV);
                ListadoCadetes.Add(NuevoCadete);
            }
        }
    }
}