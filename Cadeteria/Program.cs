
using System.IO;
using System.Net;
using System.Text.Json;

namespace Practico3
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Cadete> ListadoCadetes = new List<Cadete>();

            Cadeteria Cadeteria = CrearCadeteria.CargarDatosCadeteria("DatosCadeteria.csv");

            MetodosCadetes.CargarListaCadetesDesdeCSV(ListadoCadetes, "DatosCadetes.csv");

            


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


            foreach (var Cadete in ListadoCadetes)
            {
                Console.WriteLine(Cadete.Id);
                Console.WriteLine(Cadete.Nombre);
            }

        }
    }
}