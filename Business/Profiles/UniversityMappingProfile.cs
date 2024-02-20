using AutoMapper;
using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
using Business.Dtos.Response.CreatedResponse;
using Business.Dtos.Response.DeletedResponse;
using Business.Dtos.Response.GetListResponse;
using Business.Dtos.Response.UpdatedResponse;
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
