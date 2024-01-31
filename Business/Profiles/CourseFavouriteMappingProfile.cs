﻿using AutoMapper;
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
    public class CourseFavouriteMappingProfile : Profile
    {
        public CourseFavouriteMappingProfile()
        {
            CreateMap<CreateCourseFavouriteRequest, CourseFavourite>().ReverseMap();
            CreateMap<UpdateCourseFavouriteRequest, CourseFavourite>().ReverseMap();
            CreateMap<DeleteCourseFavouriteRequest, CourseFavourite>().ReverseMap();

            CreateMap<CourseFavourite, GetListCourseFavouriteResponse>()
                 .ForMember(dest => dest.AccountId, opt => opt.MapFrom(src => src.AccountId))
                 .ForMember(dest => dest.CourseName, opt => opt.MapFrom(src => src.Course.Name))
                .ReverseMap();


            CreateMap<Paginate<CourseFavourite>, Paginate<GetListCourseFavouriteResponse>>().ReverseMap();

            CreateMap<CourseFavourite, CreatedCourseFavouriteResponse>().ReverseMap();
            CreateMap<CourseFavourite, UpdatedCourseFavouriteResponse>().ReverseMap();
            CreateMap<CourseFavourite, DeletedCourseFavouriteResponse>().ReverseMap();
        }
    }

}
