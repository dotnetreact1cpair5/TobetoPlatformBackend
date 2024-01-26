using AutoMapper;
using Business.Dtos.Request;
using Business.Dtos.Response;
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
