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
    public class AnnouncementTypeManager : IAnnouncementTypeService
    {

        IAnnouncementTypeDal _announcementTypeDal;
        IMapper _mapper;
        public AnnouncementTypeManager(IAnnouncementTypeDal announcementTypeDal, IMapper mapper)
        {
            _announcementTypeDal = announcementTypeDal;
            _mapper = mapper;
        }

        public async Task<CreatedAnnouncementTypeResponse> Add(CreateAnnouncementTypeRequest createAnnouncementTypeRequest)
        {
            AnnouncementType announcementType = _mapper.Map<AnnouncementType>(createAnnouncementTypeRequest);
            var createdAnnouncementType = await _announcementTypeDal.AddAsync(announcementType);
            CreatedAnnouncementTypeResponse result = _mapper.Map<CreatedAnnouncementTypeResponse>(createdAnnouncementType);
            return result;
        }

        public async Task<DeletedAnnouncementTypeResponse> Delete(DeleteAnnouncementTypeRequest deleteAnnouncementTypeRequest)
        {
            AnnouncementType announcementType = await _announcementTypeDal.GetAsync(predicate: a => a.Id == deleteAnnouncementTypeRequest.Id);
            var deletedAnnouncementType = await _announcementTypeDal.DeleteAsync(announcementType, false);
            DeletedAnnouncementTypeResponse result = _mapper.Map<DeletedAnnouncementTypeResponse>(deletedAnnouncementType);
            return result;
        }

        public async Task<GetListAnnouncementTypeResponse> GetById(int announcementTypeId)
        {
            var announcementType = await _announcementTypeDal.GetAsync(predicate: a => a.Id == announcementTypeId);
            var result = _mapper.Map<GetListAnnouncementTypeResponse>(announcementType);
            return result;
        }

        public async Task<IPaginate<GetListAnnouncementTypeResponse>> GetListAnnouncementType()
        {
            var announcementType = await _announcementTypeDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetListAnnouncementTypeResponse>>(announcementType);
            return result;
        }

        public async Task<UpdatedAnnouncementTypeResponse> Update(UpdateAnnouncementTypeRequest updateAnnouncementTypeRequest)
        {
            AnnouncementType announcementType = _mapper.Map<AnnouncementType>(updateAnnouncementTypeRequest);
            var updatedAnnouncementType = await _announcementTypeDal.UpdateAsync(announcementType);
            UpdatedAnnouncementTypeResponse result = _mapper.Map<UpdatedAnnouncementTypeResponse>(updatedAnnouncementType);
            return result;
        }

    }



}
