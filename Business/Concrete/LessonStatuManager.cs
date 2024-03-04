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
    public class LessonStatuManager : ILessonStatuService
    {
        ILessonStatuDal _lessonStatuDal;
        IMapper _mapper;
        // LessonStatusBusinessRules _lessonStatusBusinessRules;
        public LessonStatuManager(ILessonStatuDal lessonStatuDal, IMapper mapper)
        {
            _lessonStatuDal = lessonStatuDal;
            _mapper = mapper;
        }

        public async Task<CreatedLessonStatuResponse> Add(CreateLessonStatuRequest createLessonStatuRequest)
        {
          //  await _lessonStatusBusinessRules.StatusNameCantBeNull(createLessonStatusRequest.Name);

            LessonStatu lessonStatu = _mapper.Map<LessonStatu>(createLessonStatuRequest);
            var createdLessonStatu = await _lessonStatuDal.AddAsync(lessonStatu);
            CreatedLessonStatuResponse result = _mapper.Map<CreatedLessonStatuResponse>(createdLessonStatu);
            return result;
        }

        public async Task<DeletedLessonStatuResponse> Delete(DeleteLessonStatuRequest deleteLessonStatuRequest)
        {

            LessonStatu lessonStatu = await _lessonStatuDal.GetAsync(predicate: a => a.Id == deleteLessonStatuRequest.Id);
            var deletedLessonStatu = await _lessonStatuDal.DeleteAsync(lessonStatu, false);
            DeletedLessonStatuResponse result = _mapper.Map<DeletedLessonStatuResponse>(deletedLessonStatu);
            return result;
        }

        public async Task<IPaginate<GetListLessonStatuResponse>> GetListLesson(PageRequest pageRequest)
        {
            var lessonStatu = await _lessonStatuDal.GetListAsync(
                orderBy: l => l.OrderBy(l => l.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListLessonStatuResponse>>(lessonStatu);
            return result;
        }

        public async Task<UpdatedLessonStatuResponse> Update(UpdateLessonStatuRequest updateLessonStatuRequest)
        {
           // await _lessonStatusBusinessRules.StatusNameCantBeNull(updateLessonStatusRequest.Name);
           //var data=await _lessonStatusDal.GetAsync(l=>l.Id==updateLessonStatusRequest.Id);
            LessonStatu lessonStatu = _mapper.Map<LessonStatu>(updateLessonStatuRequest);
            var updatedLessonStatu = await _lessonStatuDal.UpdateAsync(lessonStatu);
            UpdatedLessonStatuResponse result = _mapper.Map<UpdatedLessonStatuResponse>(updatedLessonStatu);
            return result;
        }
    }
}
