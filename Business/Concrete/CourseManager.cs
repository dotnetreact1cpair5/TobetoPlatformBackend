using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Business.Rules;
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

        public async Task<CreatedCourseResponse> Add(CreateCourseRequest createCourseRequest)
        {
           // await _courseBusinessRules.CourseNameCantBeNull(createCourseRequest.Name);
          //  await _courseBusinessRules.PathPathCantBeNull(createCourseRequest.PathPath);

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

        public async Task<IPaginate<GetListCourseResponse>> GetListCourse()
        {
            var course = await _courseDal.GetListAsync(
                include:c=>c.Include(c=>c.Category) 
                .Include(c=>c.Organization)
                .Include(c=>c.ContentType)
               );
            var result = _mapper.Map<Paginate<GetListCourseResponse>>(course);
            return result;
        }

        public async Task<UpdatedCourseResponse> Update(UpdateCourseRequest updateCourseRequest)
        {
            //await _courseBusinessRules.CourseNameCantBeNull(updateCourseRequest.Name);
            //await _courseBusinessRules.PathPathCantBeNull(updateCourseRequest.PathPath);

            Course course = _mapper.Map<Course>(updateCourseRequest);
            var updatedCourse = await _courseDal.UpdateAsync(course);
            UpdatedCourseResponse result = _mapper.Map<UpdatedCourseResponse>(updatedCourse);
            return result;
        }
    }
}
