using PatientApi.Models;

namespace PatientApi.Services
{
    public interface IPatientRepository
    {
        void AddPatient(Patient patient);
        IEnumerable<Patient> GetAllPatients();
    }
}