using AutoMapper;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class UniversityMappingProfile:Profile
    {
        public UniversityMappingProfile()
        {
            CreateMap<CreateUniversityRequest, University>().ReverseMap();
            CreateMap<UpdateUniversityRequest, University>().ReverseMap();
            CreateMap<DeleteUniversityRequest, University>().ReverseMap();

            CreateMap<University, CreatedUniversityResponse>().ReverseMap();
            CreateMap<University, UpdatedUniversityResponse>().ReverseMap();
            CreateMap<University, DeletedUniversityResponse>().ReverseMap();

            CreateMap<University, GetListUniversityResponse>().ReverseMap();
            CreateMap<Paginate<University>, Paginate<GetListUniversityResponse>>().ReverseMap();
        }
    }
}
