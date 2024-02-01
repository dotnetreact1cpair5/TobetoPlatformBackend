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
    public class CourseContentTypeManager : IContentTypeService
    {

        IContentTypeDal _courseContentTypeDal;
        IMapper _mapper;
        ContentTypeBusinessRules _contentTypeBusinessRules;
        public CourseContentTypeManager(IContentTypeDal courseContentTypeDal, IMapper mapper, ContentTypeBusinessRules contentTypeBusinessRules)
        {
            _courseContentTypeDal = courseContentTypeDal;
            _mapper = mapper;
            _contentTypeBusinessRules = contentTypeBusinessRules;
        }

        public async Task<CreatedContentTypeResponse> Add(CreateContentTypeRequest createCourseContentTypeRequest)
        {
            await _contentTypeBusinessRules.CheckIfContentTypeNameExists(createCourseContentTypeRequest.Name);
            ContentType courseContentType = _mapper.Map<ContentType>(createCourseContentTypeRequest);
            var createdCourseContentType = await _courseContentTypeDal.AddAsync(courseContentType);
            CreatedContentTypeResponse result = _mapper.Map<CreatedContentTypeResponse>(createdCourseContentType);
            return result;
        }

        public async Task<DeletedContentTypeResponse> Delete(DeleteContentTypeRequest deleteCourseContentTypeRequest)
        {
            ContentType courseContentType = _mapper.Map<ContentType>(deleteCourseContentTypeRequest);
            var deletedCourseContentType = await _courseContentTypeDal.DeleteAsync(courseContentType, false);
            DeletedContentTypeResponse result = _mapper.Map<DeletedContentTypeResponse>(deletedCourseContentType);
            return result;
        }

        public async Task<IPaginate<GetListContentTypeResponse>> GetListCourseContentType(PageRequest pageRequest)
        {
            var courseContentType = await _courseContentTypeDal.GetListAsync(
                orderBy: c => c.OrderBy(c => c.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListContentTypeResponse>>(courseContentType);
            return result;
        }

        public async Task<UpdatedContentTypeResponse> Update(UpdateContentTypeRequest updateCourseContentTypeRequest)
        {
            await _contentTypeBusinessRules.CheckIfContentTypeNameExists(updateCourseContentTypeRequest.Name);
            ContentType courseContentType = _mapper.Map<ContentType>(updateCourseContentTypeRequest);
            var updatedCourseContentType = await _courseContentTypeDal.UpdateAsync(courseContentType);
            UpdatedContentTypeResponse result = _mapper.Map<UpdatedContentTypeResponse>(updatedCourseContentType);
            return result;
        }
    }
}
