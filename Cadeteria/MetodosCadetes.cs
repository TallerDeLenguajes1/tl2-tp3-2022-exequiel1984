namespace Practico3
{
    public class MetodosCadetes
    {
        public void CargarListaCadetesDesdeCSV(List<Cadete> ListadoCadetes, string ArchivoCSV)
        {
            var LeerArchivoCSV = File.ReadAllLines(ArchivoCSV);

            for (int i = 0; i < LeerArchivoCSV.Length; i++)
            {
                var LineaCSV = (LeerArchivoCSV[i]).Split(",");
                Cadete NuevoCadete = new Cadete(LineaCSV);
                ListadoCadetes.Add(NuevoCadete);
            }
            /* FileStream MiArchivo = new FileStream("DatosCadetes.csv", FileMode.Open);
            StreamReader StrReader = new StreamReader(MiArchivo);
            string Linea = "";

            List<string[]> LecturaDelArchivo = new List<string[]>();

            while ((Linea = StrReader.ReadLine()) != null)
            {
                string[] Fila = Linea.Split(",");
                LecturaDelArchivo.Add(Fila);
            }

            for (int i = 0; i <= LecturaDelArchivo.Count-1; i++)
            {
                Cadete NuevoCadete = new Cadete(i+1, LecturaDelArchivo[i]);
                ListadoCadetes.Add(NuevoCadete);
            } */
        }
    }
}