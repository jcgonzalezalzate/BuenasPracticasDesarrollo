using System.Collections.Generic;
using System.IO;
using System.Linq;
using Pesebrera.Domain.Entities;
using Pesebrera.Domain.Interfaces.Repositories;

namespace Pesebrera.Infrastructure.Repositories
{
    public class ObtenerAnimalArchivoRepositorio : IObtenerAnimalRepositorio
    {
        public const string RutaArhivoAnimales = @"C:\\temp\\EQUINOSBOVINOS.DAT";

        public List<Animal> ObtenerAnimales()
        {
            var animalesTexto = File.ReadLines(RutaArhivoAnimales);
            return animalesTexto.Select(item => new Animal(item)).ToList();
        }
    }
}
