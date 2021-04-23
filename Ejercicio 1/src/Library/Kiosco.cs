using System;

namespace Expert_SRP
{
    public class Kiosco 
    {

         /*La clase Kiosco rompe el principio SRP ya que existe más de una razon de cambio, las cuales son:
        Por un lado verificar que haya suficiente dinero para comprar un alfajor
        Y por otro lado, hacer la conversión de la moneda.
        */ 
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) //El parametro a no es suficientemente descriptivo
        {
            Double pesos = ConvertirAPesos(dinero, moneda);
            return pesos >= a.PrecioDulce + a.PrecioMasa;
        }
        private Double ConvertirAPesos(Double dinero, String moneda)
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