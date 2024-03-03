using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models;

public class PatientVisit
{
    public int Id { get; set; }
    public int PatientId { get; set; }
    public int ConsultingDoctorId { get; set; }
    public DateTime DateTime { get; set; }
    public Doctor Doctor { get; set; }
}
