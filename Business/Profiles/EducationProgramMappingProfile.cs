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
    public class EducationProgramMappingProfile:Profile
    {
        public EducationProgramMappingProfile()
        {
            CreateMap<CreateEducationProgramRequest, EducationProgram>().ReverseMap();
            CreateMap<UpdateEducationProgramRequest, EducationProgram>().ReverseMap();
            CreateMap<DeleteEducationProgramRequest, EducationProgram>().ReverseMap();

            CreateMap<EducationProgram,CreatedEducationProgramResponse>().ReverseMap();
            CreateMap<EducationProgram, UpdatedEducationProgramResponse>().ReverseMap();
            CreateMap<EducationProgram, DeletedEducationProgramResponse>().ReverseMap();

            CreateMap<Paginate<EducationProgram>, Paginate<GetListEducationProgramResponse>>().ReverseMap();
            CreateMap<EducationProgram,GetListEducationProgramResponse>().ReverseMap();
        }
    }
}
