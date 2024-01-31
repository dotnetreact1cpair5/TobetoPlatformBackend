using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
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
    public class CoursePageLessonManager : ICoursePageLessonService
    {

        ICoursePageLessonDal _coursePageLessonDal;
        IMapper _mapper;
        public CoursePageLessonManager(ICoursePageLessonDal coursePageLessonDal, IMapper mapper)
        {
            _coursePageLessonDal = coursePageLessonDal;
            _mapper = mapper;
        }

        public async Task<CreatedCoursePageLessonResponse> Add(CreateCoursePageLessonRequest createCoursePageLessonRequest)
        {
            CoursePageLesson coursePageLesson = _mapper.Map<CoursePageLesson>(createCoursePageLessonRequest);
            var createdCoursePageLesson = await _coursePageLessonDal.AddAsync(coursePageLesson);
            CreatedCoursePageLessonResponse result = _mapper.Map<CreatedCoursePageLessonResponse>(createdCoursePageLesson);
            return result;
        }

        public async Task<DeletedCoursePageLessonResponse> Delete(DeleteCoursePageLessonRequest deleteCoursePageLessonRequest)
        {
            CoursePageLesson coursePageLesson = await _coursePageLessonDal.GetAsync(predicate: a => a.Id == deleteCoursePageLessonRequest.Id);
            var deletedCoursePageLesson = await _coursePageLessonDal.DeleteAsync(coursePageLesson, false);
            DeletedCoursePageLessonResponse result = _mapper.Map<DeletedCoursePageLessonResponse>(deletedCoursePageLesson);
            return result;
        }

        public async Task<GetListCoursePageLessonResponse> GetById(int coursePageLessonId)
        {
            var coursePageLesson = await _coursePageLessonDal.GetAsync(predicate: a => a.Id == coursePageLessonId);
            var result = _mapper.Map<GetListCoursePageLessonResponse>(coursePageLesson);
            return result;
        }

        public async Task<IPaginate<GetListCoursePageLessonResponse>> GetListCoursePageLesson()
        {
            var coursePageLesson = await _coursePageLessonDal.GetListAsync(
                include:c=>c.Include(c=>c.CoursePage)
                .Include(c=>c.Lesson));
            var result = _mapper.Map<Paginate<GetListCoursePageLessonResponse>>(coursePageLesson);
            return result;
        }

        public async Task<UpdatedCoursePageLessonResponse> Update(UpdateCoursePageLessonRequest updateCoursePageLessonRequest)
        {
            CoursePageLesson coursePageLesson = _mapper.Map<CoursePageLesson>(updateCoursePageLessonRequest);
            var updatedCoursePageLesson = await _coursePageLessonDal.UpdateAsync(coursePageLesson);
            UpdatedCoursePageLessonResponse result = _mapper.Map<UpdatedCoursePageLessonResponse>(updatedCoursePageLesson);
            return result;
        }


    }
}
