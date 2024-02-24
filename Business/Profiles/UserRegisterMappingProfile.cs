using AutoMapper;
using Business.Dtos.Request;
using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
using Business.Dtos.Response.CreatedResponse;
using Business.Dtos.Response.DeletedResponse;
using Business.Dtos.Response.GetListResponse;
using Business.Dtos.Response.UpdatedResponse;
using Core.DataAccess.Paging;
using Core.Entities.Concrete;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class UserRegisterMappingProfile : Profile
    {
        public UserRegisterMappingProfile()
        {

            CreateMap<User, CreatedUserRegisterResponse>().ReverseMap();
            CreateMap<OperationClaim, User>().ReverseMap();
            CreateMap<OperationClaim, UserOperationClaim>().ReverseMap();

            CreateMap<User, UserForRegisterRequest>().ReverseMap();
            CreateMap<User, UserForLoginRequest>().ReverseMap();
            CreateMap<User, DeletedUserResponse>().ReverseMap();
            CreateMap<User, DeleteUserRequest>().ReverseMap();

            CreateMap<User, UpdatedUserResponse>().ReverseMap();
            CreateMap<User, UpdateUserRequest>().ReverseMap();

            CreateMap<User, GetListUserResponse>().ReverseMap();
            CreateMap<Paginate<User>, Paginate<GetListUserResponse>>().ReverseMap();

        }
    }
}
