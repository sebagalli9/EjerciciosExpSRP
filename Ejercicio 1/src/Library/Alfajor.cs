using System;

namespace Expert_SRP
{

     /*
    La clase Alfajor cumple con el patron Expert, ya que es la clase que tiene la información 
    del precio de cada uno de los ingredientes. Esta información la necesita la clase Kiosco
    para calcular el precio total.
    */
    
    public class Alfajor 
    {
        public Alfajor(double precioMasa, double precioDulce)
        {
            this.PrecioDulce = precioDulce;
            this.PrecioMasa = precioMasa;
        }
        public Double PrecioDulce {get;set;}
        public Double PrecioMasa {get; set;}
    }

   

}