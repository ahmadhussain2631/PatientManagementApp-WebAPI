using AutoMapper;

namespace Domain.MappingProfile;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Entities.Patient, Models.Patient>().ReverseMap();
        CreateMap<Entities.Doctor, Models.Doctor>().ReverseMap();
        CreateMap<Entities.Disease, Models.Disease>().ReverseMap();
        CreateMap<Entities.PatientDisease, Models.PatientDisease>().ReverseMap();
        CreateMap<Entities.PatientVisit, Models.PatientVisit>().ReverseMap();
    }
}
