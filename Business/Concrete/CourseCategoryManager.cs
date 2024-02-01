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
    public class CourseCategoryManager : ICourseCategoryService
    {
        ICourseCategoryDal _courseCategoryDal;
        IMapper _mapper;
        CourseCategoryBusinessRules _courseCategoryBusinessRules;
        public CourseCategoryManager(ICourseCategoryDal courseCategoryDal, IMapper mapper, CourseCategoryBusinessRules courseCategoryBusinessRules)
        {
            _courseCategoryDal = courseCategoryDal;
            _mapper = mapper;
            _courseCategoryBusinessRules = courseCategoryBusinessRules;
        }

        public async Task<CreatedCategoryResponse> Add(CreateCategoryRequest createCourseCategoryRequest)
        {
            await _courseCategoryBusinessRules.CheckIfCourseCategoryNameExists(createCourseCategoryRequest.Name);
            Category courseCategory = _mapper.Map<Category>(createCourseCategoryRequest);
            var createdCourseCategory = await _courseCategoryDal.AddAsync(courseCategory);
            CreatedCategoryResponse result = _mapper.Map<CreatedCategoryResponse>(createdCourseCategory);
            return result;
        }

        public async Task<DeletedCategoryResponse> Delete(DeleteCategoryRequest deleteCourseCategoryRequest)
        {
            Category courseCategory = await _courseCategoryDal.GetAsync(predicate: a => a.Id == deleteCourseCategoryRequest.Id);
            var deletedCourseCategory = await _courseCategoryDal.DeleteAsync(courseCategory, false);
            DeletedCategoryResponse result = _mapper.Map<DeletedCategoryResponse>(deletedCourseCategory);
            return result;
        }

        public async Task<IPaginate<GetListCategoryResponse>> GetListCourseCategory()
        {
            var courseCategory = await _courseCategoryDal.GetListAsync();

            var result = _mapper.Map<Paginate<GetListCategoryResponse>>(courseCategory);
            return result;
        }

        public async Task<UpdatedCategoryResponse> Update(UpdateCategoryRequest updateCourseCategoryRequest)
        {
            await _courseCategoryBusinessRules.CheckIfCourseCategoryNameExists(updateCourseCategoryRequest.Name);
            Category CourseCategory = _mapper.Map<Category>(updateCourseCategoryRequest);
            var updatedCourseCategory = await _courseCategoryDal.UpdateAsync(CourseCategory);
            UpdatedCategoryResponse result = _mapper.Map<UpdatedCategoryResponse>(updatedCourseCategory);
            return result;
        }
    }
}
