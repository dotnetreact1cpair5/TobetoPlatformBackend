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
    public class CategoryMappingProfile:Profile
    {
        public CategoryMappingProfile()
        {
            CreateMap<CreateCategoryRequest, Category>().ReverseMap();
            CreateMap<UpdateCategoryRequest, Category>().ReverseMap();
            CreateMap<DeleteCategoryRequest, Category>().ReverseMap();

            CreateMap<Category, GetListCategoryResponse>().ReverseMap();
            CreateMap<Paginate<Category>, Paginate<GetListCategoryResponse>>().ReverseMap();

            CreateMap<Category, CreatedCategoryResponse>().ReverseMap();
            CreateMap<Category, UpdatedCategoryResponse>().ReverseMap();
            CreateMap<Category, DeletedCategoryResponse>().ReverseMap();
        }
    }
}
