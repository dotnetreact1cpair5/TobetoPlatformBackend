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
        //CourseBusinessRules _courseBusinessRules;
        public CourseManager(ICourseDal courseDal, IMapper mapper)
        {
            _courseDal = courseDal;
            _mapper = mapper;
        }

        public async Task<CreatedCourseResponse> Add(CreateCourseRequest createCourseRequest)
        {
            // await _courseBusinessRules.CourseNameCantBeNull(createCourseRequest.Name);
            //  await _courseBusinessRules.ImagePathCantBeNull(createCourseRequest.ImagePath);

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

        public async Task<IPaginate<GetListCourseResponse>> GetListCourse(PageRequest pageRequest)
        {
            var course = await _courseDal.GetListAsync(
               orderBy: c => c.OrderBy(c => c.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListCourseResponse>>(course);
            return result;
        }

        public async Task<UpdatedCourseResponse> Update(UpdateCourseRequest updateCourseRequest)
        {
            //await _courseBusinessRules.CourseNameCantBeNull(updateCourseRequest.Name);
            //await _courseBusinessRules.ImagePathCantBeNull(updateCourseRequest.ImagePath);

            Course course = _mapper.Map<Course>(updateCourseRequest);
            var updatedCourse = await _courseDal.UpdateAsync(course);
            UpdatedCourseResponse result = _mapper.Map<UpdatedCourseResponse>(updatedCourse);
            return result;
        }
    }
}
