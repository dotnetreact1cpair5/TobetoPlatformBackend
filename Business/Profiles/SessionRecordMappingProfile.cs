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
    public class SessionRecordMappingProfile : Profile
    {
        public SessionRecordMappingProfile()
        {
            CreateMap<CreateSessionRecordRequest, SessionRecord>().ReverseMap();
            CreateMap<UpdateSessionRecordRequest, SessionRecord>().ReverseMap();
            CreateMap<DeleteSessionRecordRequest, SessionRecord>().ReverseMap();

            CreateMap<SessionRecord, GetListSessionRecordResponse>().ReverseMap();
            CreateMap<Paginate<SessionRecord>, Paginate<GetListSessionRecordResponse>>().ReverseMap();

            CreateMap<SessionRecord, CreatedSessionRecordResponse>().ReverseMap();
            CreateMap<SessionRecord, UpdatedSessionRecordResponse>().ReverseMap();
            CreateMap<SessionRecord, DeletedSessionRecordResponse>().ReverseMap();
        }
    }

}
