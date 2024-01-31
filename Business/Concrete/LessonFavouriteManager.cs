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
    public class LessonFavouriteManager : ILessonFavouriteService
    {

        ILessonFavouriteDal _lessonFavouriteDal;
        IMapper _mapper;
        public LessonFavouriteManager(ILessonFavouriteDal lessonFavouriteDal, IMapper mapper)
        {
            _lessonFavouriteDal = lessonFavouriteDal;
            _mapper = mapper;
        }

        public async Task<CreatedLessonFavouriteResponse> Add(CreateLessonFavouriteRequest createLessonFavouriteRequest)
        {
            LessonFavourite lessonFavourite = _mapper.Map<LessonFavourite>(createLessonFavouriteRequest);
            var createdLessonFavourite = await _lessonFavouriteDal.AddAsync(lessonFavourite);
            CreatedLessonFavouriteResponse result = _mapper.Map<CreatedLessonFavouriteResponse>(createdLessonFavourite);
            return result;
        }

        public async Task<DeletedLessonFavouriteResponse> Delete(DeleteLessonFavouriteRequest deleteLessonFavouriteRequest)
        {
            LessonFavourite lessonFavourite = await _lessonFavouriteDal.GetAsync(predicate: a => a.Id == deleteLessonFavouriteRequest.Id);
            var deletedLessonFavourite = await _lessonFavouriteDal.DeleteAsync(lessonFavourite, false);
            DeletedLessonFavouriteResponse result = _mapper.Map<DeletedLessonFavouriteResponse>(deletedLessonFavourite);
            return result;
        }

        //public async Task<GetListLessonFavouriteResponse> GetByAccountId(int accountId)
        //{
        //    var lessonFavourite = await _lessonFavouriteDal.GetListAsync(predicate:ls=>ls.AccountId==accountId);
        //    var result = _mapper.Map<GetListLessonFavouriteResponse>(lessonFavourite);
        //    return result;

        //}

        public async Task<IPaginate<GetListLessonFavouriteResponse>> GetById(int accountLessonFavouriteId)
        {
            var lessonFavourite = await _lessonFavouriteDal.GetListAsync(predicate: l => l.AccountId == accountLessonFavouriteId,include:ls=>ls.Include(l=>l.Account).Include(ls=>ls.Lesson));
            var result = _mapper.Map<Paginate<GetListLessonFavouriteResponse>>(lessonFavourite);
            return result;
        }

        public async Task<IPaginate<GetListLessonFavouriteResponse>> GetListLessonFavourite()
        {
            var lessonFavourite = await _lessonFavouriteDal.GetListAsync(
                include:l=>l.Include(ls=>ls.Account).Include(ls=>ls.Lesson)
                );
            var result = _mapper.Map<Paginate<GetListLessonFavouriteResponse>>(lessonFavourite);
            return result;
        }

        public async Task<UpdatedLessonFavouriteResponse> Update(UpdateLessonFavouriteRequest updateLessonFavouriteRequest)
        {
            LessonFavourite lessonFavourite = _mapper.Map<LessonFavourite>(updateLessonFavouriteRequest);
            var updatedLessonFavourite = await _lessonFavouriteDal.UpdateAsync(lessonFavourite);
            UpdatedLessonFavouriteResponse result = _mapper.Map<UpdatedLessonFavouriteResponse>(updatedLessonFavourite);
            return result;
        }

    }


}
