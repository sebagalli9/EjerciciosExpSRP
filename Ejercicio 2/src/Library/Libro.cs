using System;

namespace SRP
{   
    public class Libro
    {
        /*
        La clase libro viola el principio SRP ya que hay dos razones de cambio diferentes,
        las cuales son: 
        1- Conocer y modificar la información de los libros, es decir el titulo, autor y codigo.
        2- Conocer y modificar la posicion donde se almacena el libro, es decir el secor y el 
        estante de bilbioteca.
        */
        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}
