namespace PatientApi.Models{
    public class Patient
    {//Modelo de datos de pacientes
        public Guid Id { get; set; } 
        // Con required, se indica que el valor debe ser proporcionado al crear un objeto
        public required string Name { get; set; }
        public required string Symptoms { get; set; }
        public required int Age { get; set; }
    }
}