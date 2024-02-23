using AutoMapper;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
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
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
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
        public CourseManager(ICourseDal courseDal,IMapper mapper,CourseBusinessRules courseBusinessRules)
        {
            _courseDal = courseDal;
            _mapper = mapper;
            _courseBusinessRules = courseBusinessRules;
        }


        //  [SecuredOperation("admin")]
        [ValidationAspect(typeof(CourseValidator))]
        // [CacheRemoveAspect("ICourseService.Get")]
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
            Course course = await _courseDal.GetAsync(predicate: a => a.Id == deleteCourseRequest.Id);
            var deletedCourse = await _courseDal.DeleteAsync(course, false);
            DeletedCourseResponse result = _mapper.Map<DeletedCourseResponse>(deletedCourse);
            return result;
        }


        public async Task<IPaginate<GetListCourseResponse>> GetByUserId(int userId)
        {
            var course = await _courseDal.GetListAsync(predicate: c => c.Id == userId,
                  include: c => c.Include(c => c.Category)
                .Include(c => c.Organization)
                .Include(c => c.ContentType)
                .Include(c => c.PathFile)
              //  .Include(c => c.User)
                );
            var result = _mapper.Map<Paginate<GetListCourseResponse>>(course);
            return result;
        }

        public async Task<IPaginate<GetListCourseResponse>> GetByCourseId(int courseId)
        {
            var courseList = await _courseDal.GetListAsync(
                  include: c => c.Include(c=>c.Lessons).ThenInclude(cl=>cl.Content)
                 .Include(c => c.Lessons)
                 .Include(c => c.Category)
                .Include(c => c.Organization)
                .Include(c => c.ContentType)
                .Include(c => c.PathFile)
                
                );
            var filteredCourses = courseList.Items.Where(a => a.Lessons.Any(c => c.CourseId == courseId)).ToList();
            var result = _mapper.Map<Paginate<GetListCourseResponse>>(filteredCourses);
            return result;
        }

        // [CacheAspect]
        // [PerformanceAspect(5)]//gecen sure 5snyeyi gecerse bildir
        public async Task<IPaginate<GetListCourseResponse>> GetListCourse()
        {
            var course = await _courseDal.GetListAsync(
                include: c => c.Include(c => c.Category)
                .Include(c => c.Organization)
                .Include(c => c.ContentType)
                .Include(c => c.PathFile)
                //.Include(c => c.User)
               );
            var result = _mapper.Map<Paginate<GetListCourseResponse>>(course);
            return result;
        }

        [ValidationAspect(typeof(CourseValidator))]
        //  [CacheRemoveAspect("ICourseService.Get")]
        //  [TransactionScopeAspect]
        public async Task<UpdatedCourseResponse> Update(UpdateCourseRequest updateCourseRequest)
        {

         //   await _courseBusinessRules.CheckIfCourseNameExists(updateCourseRequest.Name);
            Course course = _mapper.Map<Course>(updateCourseRequest);
            var updatedCourse = await _courseDal.UpdateAsync(course);
            UpdatedCourseResponse result = _mapper.Map<UpdatedCourseResponse>(updatedCourse);
            return result;
        }
    }
}
