using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Pesebrera.V2
{
    /// <summary>
    /// Programa encargado de clasificar en una pesebrera
    /// Equinos y bovinos
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            List<string> la = new List<string>(); //Listado de animales
            List<string> le = new List<string>(); //Listado de animales
            List<string> lb = new List<string>(); //Listado de animales

            //Cofiguramos lo necesario para leer el archivo de animales
            string ar = @"C:\\temp\\EQUINOSBOVINOS.DAT";

            //Leemos todas las lineas del archivo para obtener cada animal
            la = File.ReadLines(ar).ToList();

            // Iteramos en cada listado de animales para aplicar de clasificación
            // Los animales que empiecen por la letra B son Bovinos 
            foreach (string eb in la)
            {
                if (eb.ToUpper().StartsWith("B", 0))
                {
                    lb.Add(eb);
                }
                else
                {
                    le.Add(eb);
                }

            }

            // Generamaos el contenido del archivo que contiene los equinos
            string conte = "";
            foreach (string se in le)
            {
                conte = (conte
                         + (se + "\n"));
            }

            // Definimos la ruta donde se almacenarán los equinos
            string ruta = "C:\\temp\\equinos.txt";

            // Si el archivo no existe es creado
            if (!File.Exists(ruta))
            {
                File.Create(ruta).Dispose();
            }

            //Escribimos en el archivo los equinos
            File.WriteAllText(ruta, conte);

            // Generamos el contenido del archivo que contiene los bovinos
            string contb = "";
            foreach (string sb in lb)
            {
                contb = (contb
                         + (sb + "\n"));
            }

            //Definimos la ruta donde se almacenarán los bovinos
            ruta = "C:\\temp\\bovinos.txt";

            // Si el archivo no existe es creado
            if (!File.Exists(ruta))
            {
                File.Create(ruta).Dispose();
            }

            //Escribimos en el archivo los bovinos
            File.WriteAllText(ruta, contb);
        }
    }
}