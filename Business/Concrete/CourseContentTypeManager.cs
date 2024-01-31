using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Business.Rules;
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
    public class CourseContentTypeManager :ICourseContentTypeService
    {

        ICourseContentTypeDal _courseContentTypeDal;
        IMapper _mapper;
        CourseContentTypeBusinessRules _courseContentTypeBusinessRules;
        public CourseContentTypeManager(ICourseContentTypeDal courseContentTypeDal, IMapper mapper, CourseContentTypeBusinessRules courseContentTypeBusinessRules)
        {
            _courseContentTypeDal = courseContentTypeDal;
            _mapper = mapper;
            _courseContentTypeBusinessRules = courseContentTypeBusinessRules;
        }

        public async Task<CreatedCourseContentTypeResponse> Add(CreateCourseContentTypeRequest createCourseContentTypeRequest)
        {
            await _courseContentTypeBusinessRules.ContentTypeNameCantBeNull(createCourseContentTypeRequest.Name);

            ContentType courseContentType = _mapper.Map<ContentType>(createCourseContentTypeRequest);
            var createdCourseContentType = await _courseContentTypeDal.AddAsync(courseContentType);
            CreatedCourseContentTypeResponse result = _mapper.Map<CreatedCourseContentTypeResponse>(createdCourseContentType);
            return result;
        }

        public async Task<DeletedCourseContentTypeResponse> Delete(DeleteCourseContentTypeRequest deleteCourseContentTypeRequest)
        {
            ContentType courseContentType = _mapper.Map<ContentType>(deleteCourseContentTypeRequest);
            var deletedCourseContentType = await _courseContentTypeDal.DeleteAsync(courseContentType, false);
            DeletedCourseContentTypeResponse result = _mapper.Map<DeletedCourseContentTypeResponse>(deletedCourseContentType);
            return result;
        }

        public async Task<IPaginate<GetListCourseContentTypeResponse>> GetListCourseContentType(PageRequest pageRequest)
        {
            var courseContentType = await _courseContentTypeDal.GetListAsync(
                orderBy: c => c.OrderBy(c => c.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListCourseContentTypeResponse>>(courseContentType);
            return result;
        }

        public async Task<UpdatedCourseContentTypeResponse> Update(UpdateCourseContentTypeRequest updateCourseContentTypeRequest)
        {
            await _courseContentTypeBusinessRules.ContentTypeNameCantBeNull(updateCourseContentTypeRequest.Name);

            ContentType courseContentType = _mapper.Map<ContentType>(updateCourseContentTypeRequest);
            var updatedCourseContentType = await _courseContentTypeDal.UpdateAsync(courseContentType);
            UpdatedCourseContentTypeResponse result = _mapper.Map<UpdatedCourseContentTypeResponse>(updatedCourseContentType);
            return result;
        }
    }
}
