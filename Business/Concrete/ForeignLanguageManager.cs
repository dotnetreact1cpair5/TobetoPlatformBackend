﻿using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
using Business.Dtos.Response.CreatedResponse;
using Business.Dtos.Response.DeletedResponse;
using Business.Dtos.Response.GetListResponse;
using Business.Dtos.Response.UpdatedResponse;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
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
    public class ForeignLanguageManager : IForeignLanguageService
    {
        IForeignLanguageDal _foreignLanguageDal;
        IMapper _mapper;
        public ForeignLanguageManager(IForeignLanguageDal foreignLanguageDal,IMapper mapper)
        {
            _foreignLanguageDal = foreignLanguageDal;
            _mapper = mapper;
        }

        [ValidationAspect(typeof(ForeignLanguageValidator))]
        public async Task<CreatedForeignLanguageResponse> Add(CreateForeignLanguageRequest createForeignLanguageRequest)
        {
            ForeignLanguage foreignLanguage = _mapper.Map<ForeignLanguage>(createForeignLanguageRequest);
            var createdForeignLanguage = await _foreignLanguageDal.AddAsync(foreignLanguage);
            CreatedForeignLanguageResponse result = _mapper.Map<CreatedForeignLanguageResponse>(createdForeignLanguage);
            return result;
        }

        public async Task<DeletedForeignLanguageResponse> Delete(DeleteForeignLanguageRequest deleteForeignLanguageRequest)
        {
            ForeignLanguage foreignLanguage = await _foreignLanguageDal.GetAsync(d => d.Id == deleteForeignLanguageRequest.Id);
            var deletedForeignLanguage = await _foreignLanguageDal.DeleteAsync(foreignLanguage,false);
            DeletedForeignLanguageResponse result = _mapper.Map<DeletedForeignLanguageResponse>(deletedForeignLanguage);
            return result;
        }

        public async Task<IPaginate<GetListForeignLanguageResponse>> GetListForeignLanguage(PageRequest pageRequest)
        {        
            var foreignLanguage = await _foreignLanguageDal.GetListAsync(
                orderBy: f => f.OrderBy(f => f.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListForeignLanguageResponse>>(foreignLanguage);
            return result;
        }

        public async Task<UpdatedForeignLanguageResponse> Update(UpdateForeignLanguageRequest updateForeignLanguageRequest)
        {
            ForeignLanguage foreignLanguage = await _foreignLanguageDal.GetAsync(i => i.Id == updateForeignLanguageRequest.Id);
            _mapper.Map(updateForeignLanguageRequest, foreignLanguage);
            var updatedForeignLanguage = await _foreignLanguageDal.UpdateAsync(foreignLanguage);
            UpdatedForeignLanguageResponse result = _mapper.Map<UpdatedForeignLanguageResponse>(updatedForeignLanguage);
            return result;
        }
    }
}
