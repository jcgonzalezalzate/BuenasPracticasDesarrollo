using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Pesebrera.V4
{
    class Program
    {
        public const string RutaArhivoAnimales = @"C:\\temp\\EQUINOSBOVINOS.DAT";
        public const string RutaArhivoEquinos = @"C:\\temp\\equinos.txt";
        public const string RutaArhivoBovinos = @"C:\\temp\\bovinos.txt";

        public static List<string> ListadoAnimales { get; set; }

        public static List<string> ListadoEquinos { get; set; }
        
        public static List<string> ListadoBovinos { get; set; }
        
        static void Main(string[] args)
        {
            ObtenerAnimales();
            ClasificarAnimales();
            GuardarEnArchivo(RutaArhivoEquinos, ListadoEquinos);
            GuardarEnArchivo(RutaArhivoBovinos, ListadoBovinos);
        }

        private static void ObtenerAnimales()
        {
            ListadoAnimales = File.ReadLines(RutaArhivoAnimales).ToList();
        }

        private static void ClasificarAnimales()
        {
            foreach (string animal in ListadoAnimales)
            {
                if (animal.ToUpper().StartsWith("B", 0))
                {
                    ListadoBovinos.Add(animal);
                }
                else
                {
                    ListadoEquinos.Add(animal);
                }
            }
        }

        private static void GuardarEnArchivo(string rutaArchivoEspecie, List<string> listadoEspecie)
        {
            var contenidoArhivo = GenerarContenido(listadoEspecie);

            if (!File.Exists(rutaArchivoEspecie))
            {
                File.Create(rutaArchivoEspecie).Dispose();
            }

            File.WriteAllText(rutaArchivoEspecie, contenidoArhivo);
        }

        private static string GenerarContenido(List<string> listadoEspecie)
        {
            string contenidoArhivo = "";
            foreach (string especie in listadoEspecie)
            {
                contenidoArhivo += especie + "\n";
            }

            return contenidoArhivo;
        }
    }
}