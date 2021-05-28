using System;
using System.Collections.Generic;
using Pesebrera.BusinessLogic;
using Pesebrera.Data;

namespace Pesebrera.Presentation
{
    class Program
    {
        public const string RutaArhivoEquinos = @"C:\\temp\\equinos.txt";
        public const string RutaArhivoBovinos = @"C:\\temp\\bovinos.txt";
        
        static void Main(string[] args)
        {
            var obtener = new Obtener();
            var listadoAnimales = obtener.ObtenerAnimales();

            var clasificar = new Clasificar();
            clasificar.ClasificarAnimales(
                out List<string> listadoBovinos, 
                out List<string> listadoEquinos, 
                listadoAnimales);

            var guardar = new Guardar();
            guardar.GuardarEnArchivo(RutaArhivoEquinos, listadoEquinos);
            guardar.GuardarEnArchivo(RutaArhivoBovinos, listadoBovinos);
        }
    }
}
