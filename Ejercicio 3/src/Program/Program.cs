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

            Doctor doctor1 = new Doctor("Armand", "Wall Street", DateTime.Now, "Dermatólogo");
            Doctor doctor2 = new Doctor("", "Queen Street", DateTime.Now, "Cirujano");
            Doctor doctor3 = new Doctor("John Payh", "Wall Street", DateTime.Now, "Anestesista");

            ScheduleAppointment schedule = new ScheduleAppointment();

            schedule.CreateAppointment(paciente1, doctor1);
            schedule.CreateAppointment(paciente2, doctor2);
            schedule.CreateAppointment(paciente3, doctor3);
            schedule.CreateAppointment(paciente3, doctor3);
            schedule.CreateAppointment(paciente3, doctor3);
            schedule.CreateAppointment(paciente3, doctor3);
            schedule.CreateAppointment(paciente3, doctor3);
        }
    }
}
