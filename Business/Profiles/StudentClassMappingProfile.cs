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
    public class StudentClassMappingProfile : Profile
    {
        public StudentClassMappingProfile()
        {
            CreateMap<CreateStudentClassRequest, StudentClass>().ReverseMap();
            CreateMap<UpdateStudentClassRequest, StudentClass>().ReverseMap();
            CreateMap<DeleteStudentClassRequest, StudentClass>().ReverseMap();

            CreateMap<StudentClass, GetListStudentClassResponse>().ReverseMap();
            CreateMap<Paginate<StudentClass>, Paginate<GetListStudentClassResponse>>().ReverseMap();

            CreateMap<StudentClass, CreatedStudentClassResponse>().ReverseMap();
            CreateMap<StudentClass, UpdatedStudentClassResponse>().ReverseMap();
            CreateMap<StudentClass, DeletedStudentClassResponse>().ReverseMap();
        }
    }
}