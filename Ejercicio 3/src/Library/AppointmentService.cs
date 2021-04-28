using System;
using System.Text;

namespace Library
{
    /* Se crearon las clases Patient, Doctor y ScheduleAppointment para cumplir con el principio SRP 
    dejándole a la clase AppointmentService la única responsabilidad es validar los atributos AppointmentPlace y 
    Date de la clase ScheduleAppointment. */

    public class AppointmentService
    
    {
        public static bool ValidateAppointment(ScheduleAppointment schedule)
        {
            Boolean isValid = true;

            if(String.IsNullOrEmpty(schedule.AppointmentPlace) == true)
            {
                isValid = false;
            }

            if(String.IsNullOrEmpty(schedule.Date.ToString()) == true)
            {
                isValid = false;                
            }

            return isValid;
        }
    }
}
