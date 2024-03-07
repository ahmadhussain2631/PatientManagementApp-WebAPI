using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models;

public class Patient
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }

    public List<PatientDisease>? Diseases { get; set; }
    public List<PatientVisit>? Visits { get; set; }
}
