using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Domain.AppDbContext;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) :
        base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //modelBuilder.Entity<User>(entity =>
        //{
        //    entity.HasIndex(e => e.Username).IsUnique();
        //});
    }

    public DbSet<Patient> Patient { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Disease> Diseases { get; set; }
    public DbSet<PatientVisit> PatientVisits { get; set; }
    public DbSet<PatientDisease> PatientDiseases { get; set; }

}
