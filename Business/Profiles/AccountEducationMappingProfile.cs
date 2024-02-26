using AutoMapper;
using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
using Business.Dtos.Response;
using Business.Dtos.Response.CreatedResponse;
using Business.Dtos.Response.DeletedResponse;
using Business.Dtos.Response.GetListResponse;
using Business.Dtos.Response.UpdatedResponse;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class AccountEducationMappingProfile:Profile
    {
        public AccountEducationMappingProfile()
        {
            CreateMap<CreateAccountEducationRequest, AccountEducation>().ReverseMap();
            CreateMap<UpdateAccountEducationRequest, AccountEducation>().ReverseMap();
            CreateMap<DeleteAccountEducationRequest, AccountEducation>().ReverseMap();

            CreateMap<AccountEducation, CreatedAccountEducationResponse>().ReverseMap();
            CreateMap<AccountEducation, UpdatedAccountEducationResponse>().ReverseMap();
            CreateMap<AccountEducation, DeletedAccountEducationResponse>().ReverseMap();

            CreateMap<AccountEducation, GetListAccountEducationResponse>().ForMember(dest => dest.EducationStatusName, opt => opt.MapFrom(src => src.EducationStatus.Name))
    .ForMember(dest => dest.UniversityName, opt => opt.MapFrom(src => src.University.Name))
    .ForMember(dest => dest.EducationProgramName, opt => opt.MapFrom(src => src.EducationProgram.Name)).ReverseMap();
            CreateMap<Paginate<AccountEducation>, Paginate<GetListAccountEducationResponse>>().ReverseMap();
        }
    }
}
