using System;
using Library;

namespace Library
{
    /* La clase Patient cumple con el patrón Expert, ya que esta clase es la que conoce y 
    modifica los datos del paciente (tiene la responsabilidad de verificar los atributos de la clase Patient).
    Se cumple SRP ya que la unica razón de cambio sería cambiar el criterio de validación de los atributos. */

    public class Patient
    {
        public string Name {get; set;}

        public string Id {get; set;}

        public string PhoneNumber {get; set;}

        public string Age {get; set;}

        public Patient(string name, string id, string phoneNumber, string age)
        {
            this.Name = name;
            this.Id = id;
            this.PhoneNumber = phoneNumber;
            this.Age = age;
        }

        public bool ValidatePatient ()
        {
            Boolean isValid = true;

            if (string.IsNullOrEmpty(this.Name))
            {
                isValid = false;
            }

            if (string.IsNullOrEmpty(this.Id))
            {
                isValid = false;
            }

            if (string.IsNullOrEmpty(this.PhoneNumber))
            {
                isValid = false;
            }

            if (string.IsNullOrEmpty(this.Age))
            {
                isValid = false;
            }

            return isValid;
        }

    }
}