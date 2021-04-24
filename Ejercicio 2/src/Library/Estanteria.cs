using System;
using System.Collections.Generic;

namespace SRP
{
    public class Estanteria
    {
        //Creamos una lista para almancenar los libros
        public List<Libro> ListaLibros { get ; set; }


        // Se creó la clase Estantería para cumplir con el principio SRP y que la clase Libro solamente tenga una razón de cambio
        //la cual es modificar las características del libro (título, código y autor).
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        //Creamos constructor de Estantería
        public Estanteria(string sector, string estante)
        {
            SectorBiblioteca = sector;
            EstanteBiblioteca = estante;

            //Inicializamos la lista cuando se crea la instancia del objeto Estantería
            ListaLibros = new List<Libro>();
        }

        //Modificamos AlmacenarLibro para convertirlo a un método que almacena libros en una lista
        //Agregamos un parametro para ingresar una instancia de Libro y almacenarla en la ListaLibros de cada Estantería
        public void AlmacenarLibro(Libro libro)
        {
            ListaLibros.Add(libro);
        }
    }

}