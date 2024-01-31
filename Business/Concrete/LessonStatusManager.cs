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
    public class LessonStatusManager : ILessonStatusService
    {
        ILessonStatusDal _lessonStatusDal;
        IMapper _mapper;
        // LessonStatusBusinessRules _lessonStatusBusinessRules;
        public LessonStatusManager(ILessonStatusDal lessonStatusDal, IMapper mapper)
        {
            _lessonStatusDal = lessonStatusDal;
            _mapper = mapper;
        }

        public async Task<CreatedLessonStatusResponse> Add(CreateLessonStatusRequest createLessonStatusRequest)
        {
          //  await _lessonStatusBusinessRules.StatusNameCantBeNull(createLessonStatusRequest.Name);

            LessonStatus lessonStatus = _mapper.Map<LessonStatus>(createLessonStatusRequest);
            var createdLessonStatus = await _lessonStatusDal.AddAsync(lessonStatus);
            CreatedLessonStatusResponse result = _mapper.Map<CreatedLessonStatusResponse>(createdLessonStatus);
            return result;
        }

        public async Task<DeletedLessonStatusResponse> Delete(DeleteLessonStatusRequest deleteLessonStatusRequest)
        {

            LessonStatus lessonStatus = await _lessonStatusDal.GetAsync(predicate: a => a.Id == deleteLessonStatusRequest.Id);
            var deletedLessonStatus = await _lessonStatusDal.DeleteAsync(lessonStatus, false);
            DeletedLessonStatusResponse result = _mapper.Map<DeletedLessonStatusResponse>(deletedLessonStatus);
            return result;
        }

        public async Task<IPaginate<GetListLessonStatusResponse>> GetListLesson(PageRequest pageRequest)
        {
            var lessonStatus = await _lessonStatusDal.GetListAsync(
                orderBy: l => l.OrderBy(l => l.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListLessonStatusResponse>>(lessonStatus);
            return result;
        }

        public async Task<UpdatedLessonStatusResponse> Update(UpdateLessonStatusRequest updateLessonStatusRequest)
        {
           // await _lessonStatusBusinessRules.StatusNameCantBeNull(updateLessonStatusRequest.Name);
           //var data=await _lessonStatusDal.GetAsync(l=>l.Id==updateLessonStatusRequest.Id);
            LessonStatus lessonStatus = _mapper.Map<LessonStatus>(updateLessonStatusRequest);
            var updatedLessonStatus = await _lessonStatusDal.UpdateAsync(lessonStatus);
            UpdatedLessonStatusResponse result = _mapper.Map<UpdatedLessonStatusResponse>(updatedLessonStatus);
            return result;
        }
    }
}
