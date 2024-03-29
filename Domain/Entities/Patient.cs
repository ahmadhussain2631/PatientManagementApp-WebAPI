﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table(name: "Patients")]
public class Patient
{
    public int Id { get; set; }
    [Column(TypeName = "VARCHAR(100)")]
    public string Name { get; set; }
    public int Age { get; set; }
    [Column(TypeName = "VARCHAR(6)")]
    public string Gender { get; set; }
    [Column(TypeName = "VARCHAR(250)")]
    public string Address { get; set; }
    [Column(TypeName = "VARCHAR(13)")]
    public string PhoneNumber { get; set; }

    public List<PatientDisease> Diseases { get; set; }
    public List<PatientVisit> Visits { get; set; }
}
