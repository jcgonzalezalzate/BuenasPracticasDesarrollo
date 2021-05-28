using System.Collections.Generic;
using Pesebrera.Domain.Entities;
using Pesebrera.Domain.Interfaces.Services;

namespace Pesebrera.Domain.Services
{
    public class ClasificadorAnimalesServicio : IClasificadorAnimalesServicio
    {
        public List<Bovino> Bovinos { get; set; } = new List<Bovino>();

        public List<Equino> Equinos { get; set; } = new List<Equino>();

        public void ClasificarAnimales(List<Animal> listadoAnimales)
        {
            foreach (Animal animal in listadoAnimales)
            {
                if (animal.Nombre.ToUpper().StartsWith("B", 0))
                {
                    this.Bovinos.Add(new Bovino(animal.Nombre));
                }
                else
                {
                    this.Equinos.Add(new Equino(animal.Nombre));
                }
            }
        }
    }
}
