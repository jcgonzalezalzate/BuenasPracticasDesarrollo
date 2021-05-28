using Pesebrera.Application.Interfaces;
using Pesebrera.Application.Services;
using Pesebrera.Domain.Interfaces.Repositories;
using Pesebrera.Domain.Interfaces.Services;
using Pesebrera.Domain.Services;
using Pesebrera.Infrastructure.Repositories;

namespace Pesebrera.Infrastructure.IoC
{
    public class IocResolver
    {
        public static IClasificarPesebreraCasoUso CrearInstanciaClasificarPesebreraCasoUso()
        {
            IGuardarAnimalRepositorio guardarAnimalRepositorio = new GuardarAnimalArchivoRepositorio();
            IObtenerAnimalRepositorio obtenerAnimalRepositorio = new ObtenerAnimalArchivoRepositorio();
            IClasificadorAnimalesServicio clasificadorAnimalesServicio = new ClasificadorAnimalesServicio();
            
            return new ClasificarPesebreraCasoUso(
                guardarAnimalRepositorio, 
                obtenerAnimalRepositorio, 
                clasificadorAnimalesServicio);
        }
    }
}
