﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models;

public class Disease
{
    public int Id { get; set; }
    public string Name { get; set; }
}
