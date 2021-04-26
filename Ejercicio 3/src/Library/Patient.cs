using System;
using Library;

namespace Library
{
    /* La clase Patient cumple con el patrón Expert, ya que esta clase es la que conoce y 
    modifica los datos del paciente (tiene la responsabilidad de conocer y modificar los 
    atributos del paciente) */

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

    }
}