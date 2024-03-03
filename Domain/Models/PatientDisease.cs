using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models;

public class PatientDisease
{
    public int Id { get; set; }
    public int PatientId { get; set; }
    public int DiseaseId { get; set; }
    public Patient Patient { get; set; }
    public Disease Disease { get; set; }
}
