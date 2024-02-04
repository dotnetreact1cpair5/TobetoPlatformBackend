﻿using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
using Business.Dtos.Response.CreatedResponse;
using Business.Dtos.Response.DeletedResponse;
using Business.Dtos.Response.GetListResponse;
using Business.Dtos.Response.UpdatedResponse;
using Business.Rules;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CourseManager : ICourseService
    {

        ICourseDal _courseDal;
        IMapper _mapper;
        CourseBusinessRules _courseBusinessRules;
        public CourseManager(ICourseDal courseDal, IMapper mapper, CourseBusinessRules courseBusinessRules)
        {
            _courseDal = courseDal;
            _mapper = mapper;
            _courseBusinessRules = courseBusinessRules;
        }

        [ValidationAspect(typeof(CourseValidator))]
        [CacheRemoveAspect("ICourseService.Get")]
        public async Task<CreatedCourseResponse> Add(CreateCourseRequest createCourseRequest)
        {
            await _courseBusinessRules.CheckIfCourseNameExists(createCourseRequest.Name);
            Course course = _mapper.Map<Course>(createCourseRequest);
            var createdCourse = await _courseDal.AddAsync(course);
            CreatedCourseResponse result = _mapper.Map<CreatedCourseResponse>(createdCourse);
            return result;
        }
        
        public async Task<DeletedCourseResponse> Delete(DeleteCourseRequest deleteCourseRequest)
        {
            Course course = _mapper.Map<Course>(deleteCourseRequest);
            var deletedCourse = await _courseDal.DeleteAsync(course, false);
            DeletedCourseResponse result = _mapper.Map<DeletedCourseResponse>(deletedCourse);
            return result;
        }
        [CacheAspect]
        public async Task<IPaginate<GetListCourseResponse>> GetListCourse()
        {
            var course = await _courseDal.GetListAsync(
                include: c => c.Include(c => c.Category)
                .Include(c => c.Organization)
                .Include(c => c.ContentType)
               );
            var result = _mapper.Map<Paginate<GetListCourseResponse>>(course);
            return result;
        }

        [ValidationAspect(typeof(CourseValidator))]
        [CacheRemoveAspect("ICourseService.Get")]
        public async Task<UpdatedCourseResponse> Update(UpdateCourseRequest updateCourseRequest)
        {

            await _courseBusinessRules.CheckIfCourseNameExists(updateCourseRequest.Name);
            Course course = _mapper.Map<Course>(updateCourseRequest);
            var updatedCourse = await _courseDal.UpdateAsync(course);
            UpdatedCourseResponse result = _mapper.Map<UpdatedCourseResponse>(updatedCourse);
            return result;
        }
    }
}
