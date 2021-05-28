using System.Collections.Generic;
using Pesebrera.Domain.Entities;

namespace Pesebrera.Domain.Interfaces.Services
{
    public interface IClasificadorAnimalesServicio
    {
        public List<Bovino> Bovinos { get; set; }

        public List<Equino> Equinos { get; set; }

        void ClasificarAnimales(List<Animal> listadoAnimales);
    }
}
