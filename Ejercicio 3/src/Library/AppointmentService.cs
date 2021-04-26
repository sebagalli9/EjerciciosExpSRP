using System;
using System.Text;

namespace Library
{
    /* Se crearon las clases Patient, Doctor y ScheduleAppointment para cumplir con el principio SRP 
    dejándole a la clase AppointmentService la única responsabilidad de validar los datos del paciente 
    y del doctor */

    public class AppointmentService
    
    {
        public static bool ValidateAppointment(Patient patient, Doctor doctor)
        {
            Boolean isValid = true;

            if (string.IsNullOrEmpty(patient.Name))
            {
                Console.WriteLine("Unable to schedule appointment, Name is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(patient.Id))
            {
                Console.WriteLine("Unable to schedule appointment, id is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(patient.PhoneNumber))
            {
                Console.WriteLine("Unable to schedule appointment, Phone number is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(doctor.AppointmentPlace))
            {
                Console.WriteLine("Unable to schedule appointment, Appoinment place is required\n");
                isValid = false;
            }

            
            if (string.IsNullOrEmpty(doctor.Name))
            {
                Console.WriteLine("Unable to schedule appointment, Doctor name is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(doctor.Field))
            {
                Console.WriteLine("Unable to schedule appointment, Doctor field is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(patient.Age))
            {
                Console.WriteLine("Unable to schedule appointment, Patient age is required\n");
                isValid = false;
            }



            return isValid;
        }

    }
}
