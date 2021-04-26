using System;
using Library;

namespace Library
{
    /* Se creó la clase IdGenerator para respetar el principio SRP en la clase ScheduleAppointment,
    para que la unica razón de cambio de dicha clase sea mostrar el ID de la consulta y la confirmación 
    o dar un mensaje de error. */

    // Link de referencia de static: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/static
    public static class IdGenerator
    {
        private static int idNumber = 0;
        public static int CreateId()
        {
            idNumber += 1;
            return idNumber;
        }
    }
}

