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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CourseTimeSpentManager : ICourseTimeSpentService
    {

        ICourseTimeSpentDal _courseTimeSpentDal;
        IMapper _mapper;
        public CourseTimeSpentManager(ICourseTimeSpentDal courseTimeSpentDal, IMapper mapper)
        {
            _courseTimeSpentDal = courseTimeSpentDal;
            _mapper = mapper;
        }

        public async Task<CreatedCourseTimeSpentResponse> Add(CreateCourseTimeSpentRequest createCourseTimeSpentRequest)
        {
            CourseTimeSpent courseTimeSpent = _mapper.Map<CourseTimeSpent>(createCourseTimeSpentRequest);
            var createdCourseTimeSpent = await _courseTimeSpentDal.AddAsync(courseTimeSpent);
            CreatedCourseTimeSpentResponse result = _mapper.Map<CreatedCourseTimeSpentResponse>(createdCourseTimeSpent);
            return result;
        }

        public async Task<DeletedCourseTimeSpentResponse> Delete(DeleteCourseTimeSpentRequest deleteCourseTimeSpentRequest)
        {
            CourseTimeSpent courseTimeSpent = await _courseTimeSpentDal.GetAsync(predicate: a => a.Id == deleteCourseTimeSpentRequest.Id);
            var deletedCourseTimeSpent = await _courseTimeSpentDal.DeleteAsync(courseTimeSpent, false);
            DeletedCourseTimeSpentResponse result = _mapper.Map<DeletedCourseTimeSpentResponse>(deletedCourseTimeSpent);
            return result;
        }

        public async Task<GetListCourseTimeSpentResponse> GetById(int courseTimeSpentId)
        {
            var courseTimeSpent = await _courseTimeSpentDal.GetAsync(predicate: a => a.Id == courseTimeSpentId);
            var result = _mapper.Map<GetListCourseTimeSpentResponse>(courseTimeSpent);
            return result;
        }

        public async Task<IPaginate<GetListCourseTimeSpentResponse>> GetListCourseTimeSpent()
        {
            var courseTimeSpent = await _courseTimeSpentDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetListCourseTimeSpentResponse>>(courseTimeSpent);
            return result;
        }

        public async Task<UpdatedCourseTimeSpentResponse> Update(UpdateCourseTimeSpentRequest updateCourseTimeSpentRequest)
        {
            CourseTimeSpent courseTimeSpent = _mapper.Map<CourseTimeSpent>(updateCourseTimeSpentRequest);
            var updatedCourseTimeSpent = await _courseTimeSpentDal.UpdateAsync(courseTimeSpent);
            UpdatedCourseTimeSpentResponse result = _mapper.Map<UpdatedCourseTimeSpentResponse>(updatedCourseTimeSpent);
            return result;
        }

    }



}
