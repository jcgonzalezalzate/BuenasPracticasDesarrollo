using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Pesebrera.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> la = new List<string>();
            List<string> le = new List<string>();
            List<string> lb = new List<string>();
            string ar = @"C:\\temp\\EQUINOSBOVINOS.DAT";
            
            la = File.ReadLines(ar).ToList();
            
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

            string conte = "";
            foreach (string se in le)
            {
                conte = (conte
                         + (se + "\n"));
            }

            string ruta = "C:\\temp\\equinos.txt";

            if (!File.Exists(ruta))
            {
                File.Create(ruta).Dispose();
            }

            File.WriteAllText(ruta, conte);

            string contb = "";
            foreach (string sb in lb)
            {
                contb = (contb
                         + (sb + "\n"));
            }

            ruta = "C:\\temp\\bovinos.txt";

            if (!File.Exists(ruta))
            {
                File.Create(ruta).Dispose();
            }

            File.WriteAllText(ruta, contb);
        }
    }
}
