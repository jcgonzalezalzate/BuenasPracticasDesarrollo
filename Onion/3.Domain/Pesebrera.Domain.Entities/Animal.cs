namespace Pesebrera.Domain.Entities
{
    public class Animal
    {
        public string Nombre { get; set; }

        public Animal(string nombre)
        {
            this.Nombre = nombre;
        }
    }
}
