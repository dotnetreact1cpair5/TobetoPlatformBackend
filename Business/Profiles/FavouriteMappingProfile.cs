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
    public class FavouriteMappingProfile : Profile
    {
        public FavouriteMappingProfile()
        {
            CreateMap<CreateFavouriteRequest, Favourite>().ReverseMap();
            CreateMap<UpdateFavouriteRequest, Favourite>().ReverseMap();
            CreateMap<DeleteFavouriteRequest, Favourite>().ReverseMap();

            CreateMap<Favourite, GetListFavouriteResponse>()
                 .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                 .ForMember(dest => dest.CourseName, opt => opt.MapFrom(src => src.Course.Name))
                .ReverseMap();


            CreateMap<Paginate<Favourite>, Paginate<GetListFavouriteResponse>>().ReverseMap();

            CreateMap<Favourite, CreatedFavouriteResponse>().ReverseMap();
            CreateMap<Favourite, UpdatedFavouriteResponse>().ReverseMap();
            CreateMap<Favourite, DeletedFavouriteResponse>().ReverseMap();
        }
    }

}
