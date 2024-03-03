﻿namespace Domain.Entities;

public class Patient
{
    public int Id { get; set; } 
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
}
