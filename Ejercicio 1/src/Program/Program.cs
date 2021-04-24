using System;

namespace Expert_SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Los nombres de las instancias de la clase alfajor y
             kiosco se modificaron para que sean más descriptivas*/

            Alfajor alfajor = new Alfajor(10, 8.5);
            Kiosco kiosco = new Kiosco();
            if (kiosco.PuedeComprar(alfajor, 20, "$"))
            {
                Console.WriteLine("Felicitaciones! Tiene suficiente dinero para comprar un alfajor :)");
            }
            else
            {
                Console.WriteLine("Mejor consiga un trabajo :(");
            }
        }
    }
}
