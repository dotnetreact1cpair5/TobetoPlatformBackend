using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
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
        // LessonBusinessRules _lessonBusinessRules;

        public LessonManager(ILessonDal lessonDal, IMapper mapper)
        {
            _lessonDal = lessonDal;
            _mapper = mapper;

        }

        public async Task<CreatedLessonResponse> Add(CreateLessonRequest createLessonRequest)
        {
            // await _lessonBusinessRules.LessonNameCantBeNull(createLessonRequest.Name);
            //  await _lessonBusinessRules.MustBeCourseDefined(createLessonRequest.CourseId);
            // await _lessonBusinessRules.MustBeContentDefined(createLessonRequest.CourseContentId);

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

        public async Task<IPaginate<GetListLessonResponse>> GetListLesson()
        {
            var Lesson = await _lessonDal.GetListAsync(
                orderBy: l => l.OrderBy(l => l.Id));
            var result = _mapper.Map<Paginate<GetListLessonResponse>>(Lesson);
            return result;
        }

        public async Task<UpdatedLessonResponse> Update(UpdateLessonRequest updateLessonRequest)
        {
            //await _lessonBusinessRules.LessonNameCantBeNull(updateLessonRequest.Name);
            // await _lessonBusinessRules.MustBeCourseDefined(updateLessonRequest.CourseId);
            // await _lessonBusinessRules.MustBeContentDefined(updateLessonRequest.CourseContentId);

            Lesson Lesson = _mapper.Map<Lesson>(updateLessonRequest);
            var updatedLesson = await _lessonDal.UpdateAsync(Lesson);
            UpdatedLessonResponse result = _mapper.Map<UpdatedLessonResponse>(updatedLesson);
            return result;
        }
    }
}
