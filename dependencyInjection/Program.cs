using System;

namespace dependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            // constructor injection example
            // var hospitalService = new HospitalService(new MessageService());

            // property injection example
            var hospitalService = new HospitalService();
            hospitalService.MessageService = new MessageService();

            var patientX = new Patient{Name = "John Doe", Age = 20 };
            hospitalService.AddPatient(patientX);

            // method injection example
            hospitalService.AddPatient(patientX, new MessageService());
        }
    }
}
