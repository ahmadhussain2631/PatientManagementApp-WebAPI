using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Domain.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) :
        base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Patient> Patient { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Disease> Diseases { get; set; }
    public DbSet<PatientVisit> PatientVisits { get; set; }
    public DbSet<PatientDisease> PatientDiseases { get; set; }

}
