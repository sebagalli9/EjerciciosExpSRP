using System;

namespace SRP
{   
    public class Libro
    {
        /*
        Se movió AlmacenarLibros a una nueva clase Estanteria, para cumplir con el principio SRP.
        */
        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

    }
}
