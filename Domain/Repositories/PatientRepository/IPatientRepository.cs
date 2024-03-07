using Domain.Entities;

namespace Domain.Repositories;

public interface IPatientRepository
{
    Task<int> Add(Patient patient);
    Task<Patient?> Get(int patientId);
    Task<List<Patient>> GetAll();
    Task Delete(int id);
}
