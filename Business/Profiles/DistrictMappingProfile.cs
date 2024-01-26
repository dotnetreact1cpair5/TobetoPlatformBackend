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
    public class DistrictMappingProfile : Profile
    {
        public DistrictMappingProfile()
        {
            CreateMap<CreateDistrictRequest, District>().ReverseMap();
            CreateMap<UpdateDistrictRequest, District>().ReverseMap();
            CreateMap<DeleteDistrictRequest, District>().ReverseMap();

            CreateMap<District, GetListDistrictResponse>().ReverseMap();
            CreateMap<Paginate<District>, Paginate<GetListDistrictResponse>>().ReverseMap();
            CreateMap<CreatedDistrictResponse, District>().ReverseMap();

            CreateMap<District, UpdatedDistrictResponse>().ReverseMap();
            CreateMap<District, DeletedDistrictResponse>().ReverseMap();
        }
    }

}
