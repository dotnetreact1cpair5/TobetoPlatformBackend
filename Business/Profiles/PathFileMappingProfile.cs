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
    public class PathFileMappingProfile : Profile
    {
        public PathFileMappingProfile()
        {
            CreateMap<CreatePathFileRequest, PathFile>().ReverseMap();
            CreateMap<UpdatePathFileRequest, PathFile>().ReverseMap();
            CreateMap<DeletePathFileRequest, PathFile>().ReverseMap();

            CreateMap<PathFile, GetListPathFileResponse>().ReverseMap();
            CreateMap<Paginate<PathFile>, Paginate<GetListPathFileResponse>>().ReverseMap();

            CreateMap<PathFile, CreatedPathFileResponse>().ReverseMap();
            CreateMap<PathFile, UpdatedPathFileResponse>().ReverseMap();
            CreateMap<PathFile, DeletedPathFileResponse>().ReverseMap();
        }
    }
}
