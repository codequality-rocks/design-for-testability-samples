using System; 

namespace TestingApiSample
{
    public class HospitalPatientTestApi
    {
        private IHospitalService _hospitalService;

        public HospitalPatientTestApi(IHospitalService hospitalService)
        {
            _hospitalService = hospitalService ?? throw new ArgumentNullException(nameof(hospitalService));
        }

        public void AddPatient()
        {
            var patient = new Patient{Name = "John Doe", Age = 20 };
            _hospitalService.AddPatient(patient);
        }
    }
}
