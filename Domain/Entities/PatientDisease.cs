﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table(name: "PatientDiseases")]
public class PatientDisease
{
    public int Id { get; set; }
    public int PatientId { get; set; }
    public int DiseaseId { get; set; }
    public Patient Patient { get; set; }
    public Disease Disease { get; set; }
}
