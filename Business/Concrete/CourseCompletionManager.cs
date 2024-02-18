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
    public class CourseCompletionManager : ICourseCompletionService
    {

        ICourseCompletionDal _courseCompletionDal;
        IMapper _mapper;
        public CourseCompletionManager(ICourseCompletionDal courseCompletionDal, IMapper mapper)
        {
            _courseCompletionDal = courseCompletionDal;
            _mapper = mapper;
        }

        public async Task<CreatedCourseCompletionResponse> Add(CreateCourseCompletionRequest createCourseCompletionRequest)
        {
            CourseCompletion courseCompletion = _mapper.Map<CourseCompletion>(createCourseCompletionRequest);
            var createdCourseCompletion = await _courseCompletionDal.AddAsync(courseCompletion);
            CreatedCourseCompletionResponse result = _mapper.Map<CreatedCourseCompletionResponse>(createdCourseCompletion);
            return result;
        }

        public async Task<DeletedCourseCompletionResponse> Delete(DeleteCourseCompletionRequest deleteCourseCompletionRequest)
        {
            CourseCompletion courseCompletion = await _courseCompletionDal.GetAsync(predicate: a => a.Id == deleteCourseCompletionRequest.Id);
            var deletedCourseCompletion = await _courseCompletionDal.DeleteAsync(courseCompletion, false);
            DeletedCourseCompletionResponse result = _mapper.Map<DeletedCourseCompletionResponse>(deletedCourseCompletion);
            return result;
        }

        public async Task<IPaginate<GetListCourseCompletionResponse>> GetById(int accountCourseCompletionId)
        {
            var courseCompletion = await _courseCompletionDal.GetListAsync(predicate: a => a.UserId == accountCourseCompletionId,include:c=>c.Include(cc=>cc.User).Include(cc=>cc.Course));
            var result = _mapper.Map<Paginate<GetListCourseCompletionResponse>>(courseCompletion);
            return result;
        }

        public async Task<IPaginate<GetListCourseCompletionResponse>> GetListCourseCompletion()
        {
            var courseCompletion = await _courseCompletionDal.GetListAsync(include:c=>c.Include(cc=>cc.User).Include(cc=>cc.Course)
                );
            var result = _mapper.Map<Paginate<GetListCourseCompletionResponse>>(courseCompletion);
            return result;
        }

        public async Task<UpdatedCourseCompletionResponse> Update(UpdateCourseCompletionRequest updateCourseCompletionRequest)
        {
            CourseCompletion courseCompletion = _mapper.Map<CourseCompletion>(updateCourseCompletionRequest);
            var updatedCourseCompletion = await _courseCompletionDal.UpdateAsync(courseCompletion);
            UpdatedCourseCompletionResponse result = _mapper.Map<UpdatedCourseCompletionResponse>(updatedCourseCompletion);
            return result;
        }

    }


}
