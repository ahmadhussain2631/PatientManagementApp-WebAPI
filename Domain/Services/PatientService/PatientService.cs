﻿using AutoMapper;
using Domain.Models;
using Domain.Repositories;

namespace Domain.Services;

public class PatientService : IPatientService
{
    private readonly IMapper _mapper;
    private readonly IPatientRepository _patientRepository;
    public PatientService(IMapper mapper, IPatientRepository patientRepository)
    {
        _mapper = mapper;
        _patientRepository = patientRepository;
    }

    public async Task<int> Add(Patient patient)
    {
        return await _patientRepository.Add(_mapper.Map<Entities.Patient>(patient));
    }

    public async Task Delete(int id)
    {
        await _patientRepository.Delete(id);
    }

    public async Task<Patient?> Get(int patientId)
    {
        return _mapper.Map<Patient>(await _patientRepository.Get(patientId));
    }

    public async Task<List<Patient>> GetAll()
    {
        return _mapper.Map<List<Patient>>(await _patientRepository.GetAll());
    }
}
