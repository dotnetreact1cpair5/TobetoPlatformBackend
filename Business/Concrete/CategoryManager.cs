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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        IMapper _mapper;
       CategoryBusinessRules _categoryBusinessRules;
        public CategoryManager(ICategoryDal categoryDal, IMapper mapper, CategoryBusinessRules categoryBusinessRules)
        {
            _categoryDal = categoryDal;
            _mapper = mapper;
            _categoryBusinessRules = categoryBusinessRules;
        }

        public async Task<CreatedCategoryResponse> Add(CreateCategoryRequest createCategoryRequest)
        {
            await _categoryBusinessRules.CheckIfCategoryNameExists(createCategoryRequest.Name);
            Category category = _mapper.Map<Category>(createCategoryRequest);
            var createdCategory = await _categoryDal.AddAsync(category);
            CreatedCategoryResponse result = _mapper.Map<CreatedCategoryResponse>(createdCategory);
            return result;
        }

        public async Task<DeletedCategoryResponse> Delete(DeleteCategoryRequest deleteCategoryRequest)
        {
            Category category = await _categoryDal.GetAsync(predicate: a => a.Id == deleteCategoryRequest.Id);
            var deletedCategory = await _categoryDal.DeleteAsync(category, false);
            DeletedCategoryResponse result = _mapper.Map<DeletedCategoryResponse>(deletedCategory);
            return result;
        }

        public async Task<IPaginate<GetListCategoryResponse>> GetListCategory()
        {
            var category = await _categoryDal.GetListAsync();

            var result = _mapper.Map<Paginate<GetListCategoryResponse>>(category);
            return result;
        }

        public async Task<UpdatedCategoryResponse> Update(UpdateCategoryRequest updateCategoryRequest)
        {
            await _categoryBusinessRules.CheckIfCategoryNameExists(updateCategoryRequest.Name);
            Category category = _mapper.Map<Category>(updateCategoryRequest);
            var updatedCategory = await _categoryDal.UpdateAsync(category);
            UpdatedCategoryResponse result = _mapper.Map<UpdatedCategoryResponse>(updatedCategory);
            return result;
        }
    }
}
