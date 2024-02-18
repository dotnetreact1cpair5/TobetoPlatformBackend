﻿using AutoMapper;
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
    public class CourseFavouriteManager : ICourseFavouriteService
    {

        ICourseFavouriteDal _courseFavouriteDal;
        IMapper _mapper;
        public CourseFavouriteManager(ICourseFavouriteDal courseFavouriteDal, IMapper mapper)
        {
            _courseFavouriteDal = courseFavouriteDal;
            _mapper = mapper;
        }

        public async Task<CreatedCourseFavouriteResponse> Add(CreateCourseFavouriteRequest createCourseFavouriteRequest)
        {
            CourseFavourite courseFavourite = _mapper.Map<CourseFavourite>(createCourseFavouriteRequest);
            var createdCourseFavourite = await _courseFavouriteDal.AddAsync(courseFavourite);
            CreatedCourseFavouriteResponse result = _mapper.Map<CreatedCourseFavouriteResponse>(createdCourseFavourite);
            return result;
        }

        public async Task<DeletedCourseFavouriteResponse> Delete(DeleteCourseFavouriteRequest deleteCourseFavouriteRequest)
        {
            CourseFavourite courseFavourite = await _courseFavouriteDal.GetAsync(predicate: a => a.Id == deleteCourseFavouriteRequest.Id);
            var deletedCourseFavourite = await _courseFavouriteDal.DeleteAsync(courseFavourite, false);
            DeletedCourseFavouriteResponse result = _mapper.Map<DeletedCourseFavouriteResponse>(deletedCourseFavourite);
            return result;
        }

        public async Task<GetListCourseFavouriteResponse> GetById(int accountCourseFavouriteId)
        {
            var courseFavourite = await _courseFavouriteDal.GetAsync(predicate: c => c.UserId == accountCourseFavouriteId, include: ls => ls.Include(l => l.User).Include(ls => ls.Course));
            var result = _mapper.Map<GetListCourseFavouriteResponse>(courseFavourite);
            return result;
        }

        public async Task<IPaginate<GetListCourseFavouriteResponse>> GetListCourseFavourite()
        {
            var courseFavourite = await _courseFavouriteDal.GetListAsync(
                include:c=>c.Include(cf=>cf.User).Include(cf=>cf.Course));
            var result = _mapper.Map<Paginate<GetListCourseFavouriteResponse>>(courseFavourite);
            return result;
        }

        public async Task<UpdatedCourseFavouriteResponse> Update(UpdateCourseFavouriteRequest updateCourseFavouriteRequest)
        {
            CourseFavourite courseFavourite = _mapper.Map<CourseFavourite>(updateCourseFavouriteRequest);
            var updatedCourseFavourite = await _courseFavouriteDal.UpdateAsync(courseFavourite);
            UpdatedCourseFavouriteResponse result = _mapper.Map<UpdatedCourseFavouriteResponse>(updatedCourseFavourite);
            return result;
        }

    }


}
