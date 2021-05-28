using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Pesebrera.Data
{
    public class Obtener
    {
        public const string RutaArhivoAnimales = @"C:\\temp\\EQUINOSBOVINOS.DAT";

        public List<string> ObtenerAnimales()
        {
            return File.ReadLines(RutaArhivoAnimales).ToList();
        }
    }
}
