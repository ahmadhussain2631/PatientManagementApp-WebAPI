using Domain.Context;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

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

    public async Task<List<Patient>> GetAll()
    {
        return await _dbContext.Patients.ToListAsync();
    }

    public async Task Delete(int id)
    {
        // Retrieve the record from the database
        var record = await _dbContext.Patients.FindAsync(id);

        if (record != null)
        {
            // Remove the record from the context
            _dbContext.Patients.Remove(record);

            // Save changes to persist the deletion
            await _dbContext.SaveChangesAsync();
        }
    }
}
