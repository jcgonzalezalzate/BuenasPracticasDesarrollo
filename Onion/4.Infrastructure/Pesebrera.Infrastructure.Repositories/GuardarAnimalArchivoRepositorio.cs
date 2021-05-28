using System;
using System.Collections.Generic;
using System.IO;
using Pesebrera.Domain.Entities;
using Pesebrera.Domain.Interfaces.Repositories;

namespace Pesebrera.Infrastructure.Repositories
{
    public class GuardarAnimalArchivoRepositorio : IGuardarAnimalRepositorio
    {
        public const string RutaArhivoEquinos = @"C:\\temp\\equinos.txt";
        public const string RutaArhivoBovinos = @"C:\\temp\\bovinos.txt";

        public void Guardar<T>(TipoAnimalEnum tipoAnimal, List<T> listadoAnimales) where T : Animal
        {
            var contenidoArhivo = GenerarContenido(listadoAnimales);
            var rutaArchivoEspecie = ObtenerRutaSegunTipoAnimal(tipoAnimal);

            if (!File.Exists(rutaArchivoEspecie))
            {
                File.Create(rutaArchivoEspecie).Dispose();
            }

            File.WriteAllText(rutaArchivoEspecie, contenidoArhivo);
        }

        private string GenerarContenido<T>(List<T> listadoAnimales) where T : Animal
        {
            string contenidoArhivo = "";
            foreach (T animal in listadoAnimales)
            {
                contenidoArhivo += animal.Nombre + "\n";
            }

            return contenidoArhivo;
        }

        private string ObtenerRutaSegunTipoAnimal(TipoAnimalEnum tipoAnimal)
        {
            switch (tipoAnimal)
            {
                case TipoAnimalEnum.Bovino:
                    return RutaArhivoBovinos;
                case TipoAnimalEnum.Equino:
                    return RutaArhivoEquinos;
                default:
                    throw new ArgumentOutOfRangeException(nameof(tipoAnimal), tipoAnimal,
                        "Tipo de animal no soportado");
            }
        }
    }
}
