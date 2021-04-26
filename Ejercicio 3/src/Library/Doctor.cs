using System;
using Library;

namespace Library
{
    /* La clase Doctor cumple con el patrón Expert ya que es la clase experta 
    en los atributos del doctor (tiene la responsabilidad de conocerlos y modificarlos) */
    public class Doctor
    {
        public string Name {get; set;}

        public string AppointmentPlace {get; set;}

        public DateTime Date {get; set;}

        public string Field {get; set;}

        public Doctor(string name, string appointmentPlace, DateTime date, string field)
        {
            this.Name = name;
            this.AppointmentPlace = appointmentPlace;
            this.Date = date;
            this.Field = field;
        }

    }
}