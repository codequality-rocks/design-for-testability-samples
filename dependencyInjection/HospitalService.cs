
using System.Collections.Generic;

namespace dependencyInjection
{
    public class HospitalService : IHospitalService
    {
        private IMessageService messageService;
        private readonly IList<Patient> patients;
        
        // default ctor
        public HospitalService()
        {
            
        }

        // constructor with IMessageService parameter
        public HospitalService(IMessageService messageService)
        {
            this.messageService = messageService ?? throw new System.ArgumentNullException(nameof(messageService));
            patients = new List<Patient>();
        }

        public void AddPatient(Patient patient)
        {
            patients.Add(patient);
            this.messageService.SendMessage("patient {nameof(patient) added");
        }

        public void AddPatient(Patient patient, IMessageService messageService)
        {
            patients.Add(patient);
            messageService.SendMessage("patient {nameof(patient) added");
        }

        // IMessageService property for property injection
        public IMessageService MessageService
        {
            get { return this.messageService; }
            set { this.messageService = value; }
        }
        
    }
}