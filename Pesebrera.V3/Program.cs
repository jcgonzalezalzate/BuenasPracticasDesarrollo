using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Pesebrera.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listadoAnimales = new List<string>();
            List<string> listadoEquinos = new List<string>();
            List<string> listadoBovinos = new List<string>();
            string rutaArchivoAnimales = @"C:\\temp\\EQUINOSBOVINOS.DAT";

            listadoAnimales = File.ReadLines(rutaArchivoAnimales).ToList();

            foreach (string animal in listadoAnimales)
            {
                if (animal.ToUpper().StartsWith("B", 0))
                {
                    listadoBovinos.Add(animal);
                }
                else
                {
                    listadoEquinos.Add(animal);
                }

            }

            string contenidoArhivoEquinos = "";
            foreach (string equino in listadoEquinos)
            {
                contenidoArhivoEquinos += equino + "\n";
            }

            string rutaArchivoEquinos = "C:\\temp\\equinos.txt";

            if (!File.Exists(rutaArchivoEquinos))
            {
                File.Create(rutaArchivoEquinos).Dispose();
            }

            File.WriteAllText(rutaArchivoEquinos, contenidoArhivoEquinos);

            string contenidoArhivoBovinos = "";
            foreach (string bovino in listadoBovinos)
            {
                contenidoArhivoBovinos += bovino + "\n";
            }

            string rutaArchivoBovinos = "C:\\temp\\bovinos.txt";

            if (!File.Exists(rutaArchivoBovinos))
            {
                File.Create(rutaArchivoBovinos).Dispose();
            }

            File.WriteAllText(rutaArchivoBovinos, contenidoArhivoBovinos);
        }
    }
}