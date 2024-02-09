using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
using Business.Dtos.Response.CreatedResponse;
using Business.Dtos.Response.DeletedResponse;
using Business.Dtos.Response.GetListResponse;
using Business.Dtos.Response.UpdatedResponse;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LessonManager : ILessonService
    {

        ILessonDal _lessonDal;
        IMapper _mapper;
        LessonBusinessRules _lessonBusinessRules;

        public LessonManager(ILessonDal lessonDal, IMapper mapper, LessonBusinessRules lessonBusinessRules)
        {
            _lessonDal = lessonDal;
            _mapper = mapper;
            _lessonBusinessRules = lessonBusinessRules;
        }

        public async Task<CreatedLessonResponse> Add(CreateLessonRequest createLessonRequest)
        {
            await _lessonBusinessRules.CheckIfLessonNameExists(createLessonRequest.Name);
            Lesson lesson = _mapper.Map<Lesson>(createLessonRequest);
            var createdLesson = await _lessonDal.AddAsync(lesson);
            CreatedLessonResponse result = _mapper.Map<CreatedLessonResponse>(createdLesson);
            return result;
        }

        public async Task<DeletedLessonResponse> Delete(DeleteLessonRequest deleteLessonRequest)
        {
            Lesson lesson = await _lessonDal.GetAsync(predicate: a => a.Id == deleteLessonRequest.Id);
            var deletedLesson = await _lessonDal.DeleteAsync(lesson, false);
            DeletedLessonResponse result = _mapper.Map<DeletedLessonResponse>(deletedLesson);
            return result;
        }

        public async Task<IPaginate<GetListLessonResponse>> GetByCourseId(int courseId)
        {
            var lesson = await _lessonDal.GetListAsync(predicate: c => c.Id == courseId);
            var result = _mapper.Map<Paginate<GetListLessonResponse>>(lesson);
            return result;
        }

        public async Task<IPaginate<GetListLessonResponse>> GetByLessonId(int accountId)
        {
            var lesson = await _lessonDal.GetListAsync(predicate: c => c.Id == accountId);
            var result = _mapper.Map<Paginate<GetListLessonResponse>>(lesson);
            return result;
        }

        public async Task<IPaginate<GetListLessonResponse>> GetListLesson()
        {
            var Lesson = await _lessonDal.GetListAsync(
                orderBy: l => l.OrderBy(l => l.Id));
            var result = _mapper.Map<Paginate<GetListLessonResponse>>(Lesson);
            return result;
        }

        public async Task<UpdatedLessonResponse> Update(UpdateLessonRequest updateLessonRequest)
        {
            await _lessonBusinessRules.CheckIfLessonNameExists(updateLessonRequest.Name);
            Lesson Lesson = _mapper.Map<Lesson>(updateLessonRequest);
            var updatedLesson = await _lessonDal.UpdateAsync(Lesson);
            UpdatedLessonResponse result = _mapper.Map<UpdatedLessonResponse>(updatedLesson);
            return result;
        }
    }
}
