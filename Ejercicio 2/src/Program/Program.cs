using System;


namespace SRP
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos instancias de la clase Estanteria con sus respectivas coordenadas de posicion
            Estanteria estanteria1 = new Estanteria("A","7");
            Estanteria estanteria2 = new Estanteria("B","3");

            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");

            //Se guarda libro 1 en estanteria 1 y libro 2 en estanteria2
            estanteria1.AlmacenarLibro(libro1);
            estanteria2.AlmacenarLibro(libro2);

            Console.WriteLine($"Se ha agregado el libro {libro1.Titulo} a la estanteria {estanteria1.SectorBiblioteca} - {estanteria1.EstanteBiblioteca}");
            Console.WriteLine($"Se ha agregado el libro {libro2.Titulo} a la estanteria {estanteria2.SectorBiblioteca} - {estanteria2.EstanteBiblioteca}");

        }
    }
}
