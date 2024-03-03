using Domain.Entities;

namespace Domain.Repositories;

public interface IPatientRepository
{
    Task<int> Add(Patient patient);
    Task<Patient?> Get(int patientId);
}
