﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table(name: "Diseases")]
public class Disease
{
    public int Id { get; set; }
    [Column(TypeName = "VARCHAR(250)")]
    public string Name { get; set; }
}
