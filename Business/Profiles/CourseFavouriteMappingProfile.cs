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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class CourseFavouriteMappingProfile : Profile
    {
        public CourseFavouriteMappingProfile()
        {
            CreateMap<CreateCourseFavouriteRequest, CourseFavourite>().ReverseMap();
            CreateMap<UpdateCourseFavouriteRequest, CourseFavourite>().ReverseMap();
            CreateMap<DeleteCourseFavouriteRequest, CourseFavourite>().ReverseMap();

            CreateMap<CourseFavourite, GetListCourseFavouriteResponse>()
                 .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                 .ForMember(dest => dest.CourseName, opt => opt.MapFrom(src => src.Course.Name))
                .ReverseMap();


            CreateMap<Paginate<CourseFavourite>, Paginate<GetListCourseFavouriteResponse>>().ReverseMap();

            CreateMap<CourseFavourite, CreatedCourseFavouriteResponse>().ReverseMap();
            CreateMap<CourseFavourite, UpdatedCourseFavouriteResponse>().ReverseMap();
            CreateMap<CourseFavourite, DeletedCourseFavouriteResponse>().ReverseMap();
        }
    }

}
