using System;
using System.Collections.Generic;

namespace Expert_SRP
{
    public class Kiosco 
    {

        /* - Para cumplir con el principio SRP, se le quitó a la clase Kiosco
             la responsabilidad de convertir distintos tipos de monedas, déjandole cómo única razón de cambio 
             verificar que el dinero sea suficiente para comprar uno o varios alfajores.*/ 

        public Boolean PuedeComprar(Alfajor alfajor, Double dinero, String moneda)
        {
            Double pesos = Dinero.ConvertirAPesos(dinero, moneda);
            return pesos >= alfajor.PrecioDulce + alfajor.PrecioMasa;
        }
    }
}