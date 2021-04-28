using System;
using Library;

namespace Library
{
    /* Esta clase tiene la responsabilidad de devolver la información de la consulta.
    Esta clase cumple con el principio SRP ya que la única razón de cambio posible sería cambiar
    la información que se quiere devolver */
    public class ScheduleAppointment
    {
        public DateTime Date {get; set;}
        public string AppointmentPlace {get; set;}
        public ScheduleAppointment(DateTime date, string appointmentPlace)
        {
            this.Date = date;
            this.AppointmentPlace = appointmentPlace;
        }

        public string CreateAppointment(Patient patient, Doctor doctor, ScheduleAppointment schedule)
        {
            if(AppointmentService.ValidateAppointment(schedule) && doctor.ValidateDoctor() && patient.ValidatePatient())
            {
                return ("Scheduling appointment..." + '\n' + "Your ID Appointment is: " + IdGenerator.CreateId().ToString() + '\n' + "Doctor: " + doctor.Name + '\n' + "Date: " + this.Date + '\n' + "Place: " + this.AppointmentPlace + '\n');
            }
            else
            {
                return ("Unable to schedule appointment" + '\n');
            }

        }
        
    }
}