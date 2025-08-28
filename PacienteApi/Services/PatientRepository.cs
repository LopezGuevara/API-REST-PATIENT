using PatientApi.Models;

namespace PatientApi.Services
{
    public class PatientRepository : IPatientRepository
    {
        private readonly List<Patient> _patients = new List<Patient>();

        public void AddPatient(Patient patient)
        {
            _patients.Add(patient);
        }

        public IEnumerable<Patient> GetAllPatients()
        {
            return _patients;
        }
    }
}