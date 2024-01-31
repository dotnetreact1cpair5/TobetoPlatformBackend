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
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CoursePageManager : ICoursePageService
    {

        ICoursePageDal _coursePageDal;
        IMapper _mapper;
        CoursePageBusinessRules _coursePageBusinessRules;
        public CoursePageManager(ICoursePageDal coursePageDal, IMapper mapper,CoursePageBusinessRules coursePageBusinessRules)
        {
            _coursePageDal = coursePageDal;
            _mapper = mapper;
            _coursePageBusinessRules = coursePageBusinessRules;
        }

        
        public async Task<CreatedCoursePageResponse> Add(CreateCoursePageRequest createCoursePageRequest)
        {
            await _coursePageBusinessRules.CourseNameOfTheSameName(createCoursePageRequest.Name);
            CoursePage coursePage = _mapper.Map<CoursePage>(createCoursePageRequest);
            var createdCoursePage = await _coursePageDal.AddAsync(coursePage);
            CreatedCoursePageResponse result = _mapper.Map<CreatedCoursePageResponse>(createdCoursePage);
            return result;
        }

        public async Task<DeletedCoursePageResponse> Delete(DeleteCoursePageRequest deleteCoursePageRequest)
        {
            CoursePage coursePage = await _coursePageDal.GetAsync(predicate: a => a.Id == deleteCoursePageRequest.Id);
            var deletedCoursePage = await _coursePageDal.DeleteAsync(coursePage, false);
            DeletedCoursePageResponse result = _mapper.Map<DeletedCoursePageResponse>(deletedCoursePage);
            return result;
        }

        public async Task<GetListCoursePageResponse> GetById(int coursePageId)
        {
            var coursePage = await _coursePageDal.GetListAsync(
                include:c=>c.Include(g=>g.ContentCoursePages).ThenInclude(c=>c.Content));
            var filteredCoursePages = coursePage.Items.Where(g => g.ContentCoursePages.Any(cp => cp.CoursePageId == coursePageId)).ToList();
            var result = _mapper.Map<GetListCoursePageResponse>(coursePage);
            return result;
        }

        public async Task<IPaginate<GetListCoursePageResponse>> GetListCoursePage()
        {
            var coursePage = await _coursePageDal.GetListAsync(
                // include: c => c.Include(c => c.ContentCoursePages).ThenInclude(cp => cp.Content)
                //.Include(c => c.CourseCoursePages).ThenInclude(cp => cp.Course)
                //.Include(c => c.CoursePageLessons).ThenInclude(cp => cp.Lesson)
                );
            var result = _mapper.Map<Paginate<GetListCoursePageResponse>>(coursePage);
            return result;
        }

        public async Task<UpdatedCoursePageResponse> Update(UpdateCoursePageRequest updateCoursePageRequest)
        {
            CoursePage coursePage = _mapper.Map<CoursePage>(updateCoursePageRequest);
            var updatedCoursePage = await _coursePageDal.UpdateAsync(coursePage);
            UpdatedCoursePageResponse result = _mapper.Map<UpdatedCoursePageResponse>(updatedCoursePage);
            return result;
        }


    }
}
