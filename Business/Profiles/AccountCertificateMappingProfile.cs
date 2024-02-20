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
    public class AccountCertificateMappingProfile : Profile
    {
        public AccountCertificateMappingProfile()
        {
            CreateMap<CreateAccountCertificateRequest, AccountCertificate>().ReverseMap();
            CreateMap<UpdateAccountCertificateRequest, AccountCertificate>().ReverseMap();
            CreateMap<DeleteAccountCertificateRequest, AccountCertificate>().ReverseMap();

            CreateMap<AccountCertificate, GetListAccountCertificateResponse>().ReverseMap();
            CreateMap<Paginate<AccountCertificate>, Paginate<GetListAccountCertificateResponse>>().ReverseMap();

            CreateMap<AccountCertificate, CreatedAccountCertificateResponse>().ReverseMap();
            CreateMap<AccountCertificate, UpdatedAccountCertificateResponse>().ReverseMap();
            CreateMap<AccountCertificate, DeletedAccountCertificateResponse>().ReverseMap();
        }
    }
}
