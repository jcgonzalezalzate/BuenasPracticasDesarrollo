using System.Collections.Generic;
using Pesebrera.Domain.Entities;

namespace Pesebrera.Domain.Interfaces.Repositories
{
    public interface IGuardarAnimalRepositorio
    {
        void Guardar<T>(TipoAnimalEnum tipoAnimal, List<T> listadoAnimales) where T : Animal;
    }
}
