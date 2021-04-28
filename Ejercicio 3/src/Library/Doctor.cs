using System;
using Library;

namespace Library
{
    /* La clase Doctor cumple con el patrón Expert ya que es la clase experta en los atributos 
    del doctor (tiene la responsabilidad de validar los atributos de la clase Doctor)     
    Se cumple SRP ya que la unica razón de cambio sería cambiar el criterio de validación de los atributos. */

    public class Doctor
    {
        public string Name {get; set;}

        public string Field {get; set;}

        public Doctor(string name, string field)
        {
            this.Name = name;
            this.Field = field;
        }

        public bool ValidateDoctor()
        {
            Boolean isValid = true;

            if (string.IsNullOrEmpty(this.Name))
            {
                isValid = false;
            }

            if (string.IsNullOrEmpty(this.Field))
            {
                isValid = false;
            }

            return isValid;
        }
    }
}