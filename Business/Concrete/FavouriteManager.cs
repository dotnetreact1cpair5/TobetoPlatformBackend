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
    public class FavouriteManager : IFavouriteService
    {

        IFavouriteDal _favouriteDal;
        IMapper _mapper;
        public FavouriteManager(IFavouriteDal favouriteDal, IMapper mapper)
        {
            _favouriteDal = favouriteDal;
            _mapper = mapper;
        }

        public async Task<CreatedFavouriteResponse> Add(CreateFavouriteRequest createFavouriteRequest)
        {
            Favourite favourite = _mapper.Map<Favourite>(createFavouriteRequest);
            var createdFavourite = await _favouriteDal.AddAsync(favourite);
            CreatedFavouriteResponse result = _mapper.Map<CreatedFavouriteResponse>(createdFavourite);
            return result;
        }

        public async Task<DeletedFavouriteResponse> Delete(DeleteFavouriteRequest deleteFavouriteRequest)
        {
            Favourite favourite = await _favouriteDal.GetAsync(predicate: a => a.Id == deleteFavouriteRequest.Id);
            var deletedFavourite = await _favouriteDal.DeleteAsync(favourite, false);
            DeletedFavouriteResponse result = _mapper.Map<DeletedFavouriteResponse>(deletedFavourite);
            return result;
        }

        public async Task<GetListFavouriteResponse> GetById(int userFavouriteId)
        {
            var favourite = await _favouriteDal.GetAsync(predicate: c => c.UserId == userFavouriteId, include: ls => ls.Include(l => l.User).Include(ls => ls.Course));
            var result = _mapper.Map<GetListFavouriteResponse>(favourite);
            return result;
        }

        public async Task<IPaginate<GetListFavouriteResponse>> GetListFavourite()
        {
            var favourite = await _favouriteDal.GetListAsync(
                include:c=>c.Include(cf=>cf.User).Include(cf=>cf.Course));
            var result = _mapper.Map<Paginate<GetListFavouriteResponse>>(favourite);
            return result;
        }

        public async Task<UpdatedFavouriteResponse> Update(UpdateFavouriteRequest updateFavouriteRequest)
        {
            Favourite favourite = _mapper.Map<Favourite>(updateFavouriteRequest);
            var updatedFavourite = await _favouriteDal.UpdateAsync(favourite);
            UpdatedFavouriteResponse result = _mapper.Map<UpdatedFavouriteResponse>(updatedFavourite);
            return result;
        }

    }


}
