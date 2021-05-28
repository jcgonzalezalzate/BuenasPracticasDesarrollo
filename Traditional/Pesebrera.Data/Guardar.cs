using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Pesebrera.Data
{
    public class Guardar
    {
        public void GuardarEnArchivo(string rutaArchivoEspecie, List<string> listadoEspecie)
        {
            var contenidoArhivo = GenerarContenido(listadoEspecie);

            if (!File.Exists(rutaArchivoEspecie))
            {
                File.Create(rutaArchivoEspecie).Dispose();
            }

            File.WriteAllText(rutaArchivoEspecie, contenidoArhivo);
        }

        private string GenerarContenido(List<string> listadoEspecie)
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
