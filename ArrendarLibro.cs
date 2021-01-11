using System;
namespace SRPLibro
{
    public class ArrendarLibro
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vas a alquilar un libro");

            Obra miLibroAlquilado = new Obra();
            miLibroAlquilado.Describir();

            Console.WriteLine(miLibroAlquilado.Autor + " " + miLibroAlquilado.Titutlo);
        }
    }
}
