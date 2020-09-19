namespace dependencyInjection
{
    public interface IHospitalService
    {
        void AddPatient(Patient patient);
        void AddPatient(Patient patient, IMessageService messageService);
        IMessageService MessageService { get; set;}
    }
}