using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient paciente1 = new Patient("Steven Jhonson", "986782342", "5555-555-555", "40");
            Patient paciente2 = new Patient("Ralf Manson", "", "5555-555-555", "");
            Patient paciente3 = new Patient("John Dow", "515656561", "5566-5555-6121", "88");

            Doctor doctor1 = new Doctor("Armand", "Dermatólogo");
            Doctor doctor2 = new Doctor("", "Cirujano");
            Doctor doctor3 = new Doctor("John Payh", "Anestesista");

            ScheduleAppointment schedule1 = new ScheduleAppointment(DateTime.Now, "Wall Street");
            ScheduleAppointment schedule2 = new ScheduleAppointment(DateTime.Now, "Queen Street");
            ScheduleAppointment schedule3 = new ScheduleAppointment(DateTime.Now, "Boston");

            Console.WriteLine(schedule2.CreateAppointment(paciente2, doctor2, schedule2));
            Console.WriteLine(schedule1.CreateAppointment(paciente1, doctor1, schedule1));
            Console.WriteLine(schedule3.CreateAppointment(paciente3, doctor3, schedule3));
            Console.WriteLine(schedule1.CreateAppointment(paciente3, doctor3, schedule1));
            Console.WriteLine(schedule2.CreateAppointment(paciente3, doctor3, schedule2));
            Console.WriteLine(schedule3.CreateAppointment(paciente3, doctor3, schedule3));
            Console.WriteLine(schedule1.CreateAppointment(paciente3, doctor3, schedule1));
        }
    }
}
