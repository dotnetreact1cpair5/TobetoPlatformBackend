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
    public class AccountStudentClassMappingProfile : Profile
    {
        public AccountStudentClassMappingProfile()
        {
            CreateMap<CreateAccountStudentClassRequest, AccountStudentClass>().ReverseMap();
            CreateMap<UpdateAccountStudentClassRequest, AccountStudentClass>().ReverseMap();
            CreateMap<DeleteAccountStudentClassRequest, AccountStudentClass>().ReverseMap();

            CreateMap<AccountStudentClass, GetListAccountStudentClassResponse>()
                .ForMember(dest=>dest.StudentClassName,opt=>opt.MapFrom(src=>src.StudentClass.Name))
                 .ForMember(dest=>dest.AccountFirstLastName,opt=>opt.MapFrom(src=>src.Account.User.FirstName+ " " +src.Account.User.LastName))
                 
                .ReverseMap();
            CreateMap<Paginate<AccountStudentClass>, Paginate<GetListAccountStudentClassResponse>>().ReverseMap();

            CreateMap<AccountStudentClass, CreatedAccountStudentClassResponse>().ReverseMap();
            CreateMap<AccountStudentClass, UpdatedAccountStudentClassResponse>().ReverseMap();
            CreateMap<AccountStudentClass, DeletedAccountStudentClassResponse>().ReverseMap();
        }
    }
}
