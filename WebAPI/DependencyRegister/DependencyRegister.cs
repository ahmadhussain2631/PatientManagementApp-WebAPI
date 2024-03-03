using Domain.Context;
using Domain.Repositories;
using Domain.Services;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.DependencyRegister;

public static class DependencyRegister
{
    /// <summary>
    /// Add Business Services
    /// </summary>
    /// <param name="services"></param>
    public static void AddBusinessServices(this IServiceCollection services)
    {
        services.AddScoped<IPatientService, PatientService>();
        services.AddScoped<IDoctorService, DoctorService>();
        services.AddScoped<IPatientVisitService, PatientVisitService>();
    }

    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IPatientRepository, PatientRepository>();
        services.AddScoped<IDoctorRepository, DoctorRepository>();
        services.AddScoped<IPatientVisitRepository, PatientVisitRepository>();
    }

    public static void AddSqlDbContext(this IServiceCollection services,
         IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(
            (DbContextOptionsBuilder options) =>
            {
                options.UseSqlServer(configuration.GetConnectionString("AppDbContext"));
            }
        );
    }
}
