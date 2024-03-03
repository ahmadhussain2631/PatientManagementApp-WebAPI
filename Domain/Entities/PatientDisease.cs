namespace Domain.Entities;

public class PatientDisease
{
    public int Id { get; set; }
    public int PatientId { get; set; }
    public int DiseaseId { get; set; }
}
