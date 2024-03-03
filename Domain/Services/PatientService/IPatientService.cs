using Domain.Models;

namespace Domain.Services;

public interface IPatientService
{
    Task<int> Add(Patient patient);
    Task<Patient?> Get(int patientId);
}
