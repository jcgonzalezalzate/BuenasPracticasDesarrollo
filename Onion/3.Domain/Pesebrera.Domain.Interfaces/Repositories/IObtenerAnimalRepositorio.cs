using System.Collections.Generic;
using Pesebrera.Domain.Entities;

namespace Pesebrera.Domain.Interfaces.Repositories
{
    public interface IObtenerAnimalRepositorio
    {
        List<Animal> ObtenerAnimales();
    }
}
