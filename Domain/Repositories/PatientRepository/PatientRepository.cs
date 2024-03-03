using Domain.Context;
using Domain.Entities;

namespace Domain.Repositories;

public class PatientRepository : IPatientRepository
{
    private readonly AppDbContext _dbContext;
    public PatientRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<int> Add(Patient patient)
    {
        await _dbContext.AddAsync(patient);
        await _dbContext.SaveChangesAsync();
        return patient.Id;
    }

    public async Task<Patient?> Get(int patientId)
    {
       return await _dbContext.Patients.FindAsync(patientId);
    }
}
