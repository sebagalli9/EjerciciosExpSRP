using System;
using Library;

namespace Library
{
    /* Esta clase tiene la responsabilidad de agendar una consulta y de mostrar una ID única por
    consulta (número de consulta).
    Esta clase cumple con el principio SRP ya que la única razón de cambio posible es la forma en 
    que se muestra la información en pantalla */
    public class ScheduleAppointment
    {
        public void CreateAppointment(Patient patient, Doctor doctor)
        {
            if(AppointmentService.ValidateAppointment(patient, doctor) == true)
            {
                Console.WriteLine($"Scheduling appointment...\nYour ID Appointment is: {(IdGenerator.CreateId().ToString())}");
            }
            else
            {
                Console.WriteLine("Unable to schedule appointment\n");
            }

        }
        
    }
}