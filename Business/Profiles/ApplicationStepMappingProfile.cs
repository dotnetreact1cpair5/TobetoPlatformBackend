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
    public class ApplicationStepMappingProfile:Profile
    {
        public ApplicationStepMappingProfile()
        {
            CreateMap<CreateApplicationStepRequest, ApplicationStep>().ReverseMap();
            CreateMap<UpdateApplicationStepRequest, ApplicationStep>().ReverseMap();
            CreateMap<DeleteApplicationStepRequest, ApplicationStep>().ReverseMap();

            CreateMap<ApplicationStep, CreatedApplicationStepResponse>().ReverseMap();
            CreateMap<ApplicationStep, UpdatedApplicationStepResponse>().ReverseMap();
            CreateMap<ApplicationStep, DeletedApplicationStepResponse>().ReverseMap();

            CreateMap<ApplicationStep, GetListApplicationStepResponse>().ReverseMap();
            CreateMap<Paginate<ApplicationStep>, Paginate<GetListApplicationStepResponse>>().ReverseMap();
        }
    }
}
