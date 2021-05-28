using Pesebrera.Application.Interfaces;
using Pesebrera.Infrastructure.IoC;

namespace Pesebrera.UI.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IClasificarPesebreraCasoUso clasificarPesebrera = IocResolver.CrearInstanciaClasificarPesebreraCasoUso();
            clasificarPesebrera.Clasificar();
        }
    }
}
