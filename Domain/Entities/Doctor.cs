using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table(name: "Doctors")]
public class Doctor
{
    public int Id { get; set; }
    [Column(TypeName = "VARCHAR(50)")]
    public string Name { get; set; }
    [Column(TypeName = "VARCHAR(250)")]
    public string Specialization { get; set; }
}
