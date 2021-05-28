using System;
using System.Collections.Generic;

namespace Pesebrera.BusinessLogic
{
    public class Clasificar
    {
        public void ClasificarAnimales( 
            out List<string> listadoBovinos, 
            out List<string> listadoEquinos,
            List<string> listadoAnimales)
        {
            listadoBovinos = new List<string>();
            listadoEquinos = new List<string>();

            foreach (string animal in listadoAnimales)
            {
                if (animal.ToUpper().StartsWith("B", 0))
                {
                    listadoBovinos.Add(animal);
                }
                else
                {
                    listadoEquinos.Add(animal);
                }
            }
        }
    }
}
