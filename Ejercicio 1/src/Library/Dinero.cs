using System;
using System.Collections.Generic;

namespace Expert_SRP
{
    public class Dinero 
    {
        /* - Para respetar el patrón Expert, se creó la clase Dinero,
           ya que es la clase con la información necesaria para convertir distintos tipos de moneda.
        
           - El estado del método ConvertirAPesos se debió cambiar a público y estático,
           para poder tener acceso al mismo desde la clase Kiosco.
           
           - La única razón de cambio para la clase Dinero, sería querer convertir desde otro tipo
           de moneda (diferente del dólar) a pesos, cumpliendo de esta forma con el principio SRP.*/

        public static Double ConvertirAPesos(Double dinero, String moneda) 
        {
            if (moneda.Equals("U$S")) 
            {
                return dinero / 30;
            } 
            else if (moneda.Equals("$")) 
            {
                return dinero;
            }
            else 
            {
                return -1;
            }
        }
    }
}