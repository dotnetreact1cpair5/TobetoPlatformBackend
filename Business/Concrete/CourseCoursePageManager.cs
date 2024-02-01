using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
using Business.Dtos.Response.CreatedResponse;
using Business.Dtos.Response.DeletedResponse;
using Business.Dtos.Response.GetListResponse;
using Business.Dtos.Response.UpdatedResponse;
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
    public class CourseCoursePageManager : ICourseCoursePageService
    {

        ICourseCoursePageDal _courseCoursePageDal;
        IMapper _mapper;
        public CourseCoursePageManager(ICourseCoursePageDal courseCoursePageDal, IMapper mapper)
        {
            _courseCoursePageDal = courseCoursePageDal;
            _mapper = mapper;
        }

        public async Task<CreatedCourseCoursePageResponse> Add(CreateCourseCoursePageRequest createCourseCoursePageRequest)
        {
            CourseCoursePage courseCoursePage = _mapper.Map<CourseCoursePage>(createCourseCoursePageRequest);
            var createdCourseCoursePage = await _courseCoursePageDal.AddAsync(courseCoursePage);
            CreatedCourseCoursePageResponse result = _mapper.Map<CreatedCourseCoursePageResponse>(createdCourseCoursePage);
            return result;
        }

        public async Task<DeletedCourseCoursePageResponse> Delete(DeleteCourseCoursePageRequest deleteCourseCoursePageRequest)
        {
            CourseCoursePage courseCoursePage = await _courseCoursePageDal.GetAsync(predicate: a => a.Id == deleteCourseCoursePageRequest.Id);
            var deletedCourseCoursePage = await _courseCoursePageDal.DeleteAsync(courseCoursePage, false);
            DeletedCourseCoursePageResponse result = _mapper.Map<DeletedCourseCoursePageResponse>(deletedCourseCoursePage);
            return result;
        }

        public async Task<GetListCourseCoursePageResponse> GetById(int courseCoursePageId)
        {
            var courseCoursePage = await _courseCoursePageDal.GetAsync(predicate: a => a.Id == courseCoursePageId);
            var result = _mapper.Map<GetListCourseCoursePageResponse>(courseCoursePage);
            return result;
        }

        public async Task<IPaginate<GetListCourseCoursePageResponse>> GetListCourseCoursePage()
        {
            var courseCoursePage = await _courseCoursePageDal.GetListAsync(
                include:c=>c.Include(c=>c.CoursePage).Include(c=>c.Course));
            var result = _mapper.Map<Paginate<GetListCourseCoursePageResponse>>(courseCoursePage);
            return result;
        }

        public async Task<UpdatedCourseCoursePageResponse> Update(UpdateCourseCoursePageRequest updateCourseCoursePageRequest)
        {
            CourseCoursePage courseCoursePage = _mapper.Map<CourseCoursePage>(updateCourseCoursePageRequest);
            var updatedCourseCoursePage = await _courseCoursePageDal.UpdateAsync(courseCoursePage);
            UpdatedCourseCoursePageResponse result = _mapper.Map<UpdatedCourseCoursePageResponse>(updatedCourseCoursePage);
            return result;
        }


    }

}
