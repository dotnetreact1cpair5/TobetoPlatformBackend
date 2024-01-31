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
    public class LessonFavouriteMappingProfile : Profile
    {
        public LessonFavouriteMappingProfile()
        {
            CreateMap<CreateLessonFavouriteRequest, LessonFavourite>().ReverseMap();
            CreateMap<UpdateLessonFavouriteRequest, LessonFavourite>().ReverseMap();
            CreateMap<DeleteLessonFavouriteRequest, LessonFavourite>().ReverseMap();

            CreateMap<LessonFavourite, GetListLessonFavouriteResponse>()
                .ForMember(dest=>dest.AccountId,opt=>opt.MapFrom(src=>src.AccountId))
                .ForMember(dest=>dest.LessonName,opt=>opt.MapFrom(src=>src.Lesson.Name))
                .ReverseMap();
            CreateMap<Paginate<LessonFavourite>, Paginate<GetListLessonFavouriteResponse>>().ReverseMap();

            CreateMap<LessonFavourite, CreatedLessonFavouriteResponse>().ReverseMap();
            CreateMap<LessonFavourite, UpdatedLessonFavouriteResponse>().ReverseMap();
            CreateMap<LessonFavourite, DeletedLessonFavouriteResponse>().ReverseMap();
        }
    }

}
