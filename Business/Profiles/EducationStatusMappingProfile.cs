using AutoMapper;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class EducationStatusMappingProfile:Profile
    {
        public EducationStatusMappingProfile()
        {
            CreateMap<CreateEducationStatusRequest, EducationStatus>().ReverseMap();
            CreateMap<UpdateEducationStatusRequest, EducationStatus>().ReverseMap();
            CreateMap<DeleteEducationStatusRequest, EducationStatus>().ReverseMap();

            CreateMap<EducationStatus, CreatedEducationStatusResponse>().ReverseMap();
            CreateMap<EducationStatus, UpdatedEducationStatusResponse>().ReverseMap();
            CreateMap<EducationStatus, DeletedEducationStatusResponse>().ReverseMap();

            CreateMap<EducationStatus, GetListEducationStatusResponse>().ReverseMap();
            CreateMap<Paginate<EducationStatus>, Paginate<GetListEducationStatusResponse>>().ReverseMap();
        }
    }
}
