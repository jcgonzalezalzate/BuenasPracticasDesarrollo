using System;
using System.Collections.Generic;
using Pesebrera.Application.Interfaces;
using Pesebrera.Domain.Entities;
using Pesebrera.Domain.Interfaces.Repositories;
using Pesebrera.Domain.Interfaces.Services;

namespace Pesebrera.Application.Services
{
    public class ClasificarPesebreraCasoUso : IClasificarPesebreraCasoUso
    {
        private readonly IClasificadorAnimalesServicio ClasificadorAnimalesServicio;

        private readonly IObtenerAnimalRepositorio ObtenerAnimalRepositorio;

        private readonly IGuardarAnimalRepositorio GuardarAnimalRepositorio;

        public ClasificarPesebreraCasoUso(
            IGuardarAnimalRepositorio guardarAnimalRepositorio,
            IObtenerAnimalRepositorio obtenerAnimalRepositorio,
            IClasificadorAnimalesServicio clasificadorAnimalesServicio)
        {
            this.GuardarAnimalRepositorio = guardarAnimalRepositorio;
            this.ObtenerAnimalRepositorio = obtenerAnimalRepositorio;
            this.ClasificadorAnimalesServicio = clasificadorAnimalesServicio;
        }

        public void Clasificar()
        {
            try
            {
                List<Animal> animales = this.ObtenerAnimalRepositorio.ObtenerAnimales();
                this.ClasificadorAnimalesServicio.ClasificarAnimales(animales);

                List<Bovino> bovinos = ClasificadorAnimalesServicio.Bovinos;
                List<Equino> equinos = ClasificadorAnimalesServicio.Equinos;

                this.GuardarAnimalRepositorio.Guardar(TipoAnimalEnum.Bovino, bovinos);
                this.GuardarAnimalRepositorio.Guardar(TipoAnimalEnum.Equino, equinos);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex);
                throw;
            }
        }
    }
}
