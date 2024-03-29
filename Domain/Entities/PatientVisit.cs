﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table(name: "PatientVisits")]
public class PatientVisit
{
    public int Id { get; set; }
    public int PatientId { get; set; }
    [ForeignKey("Doctor")]
    public int ConsultingDoctorId { get; set; }
    public DateTime DateTime { get; set; }
    public Doctor Doctor { get; set; }
}
