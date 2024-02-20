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
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ContentTypeManager : IContentTypeService
    {

        IContentTypeDal _contentTypeDal;
        IMapper _mapper;
        ContentTypeBusinessRules _contentTypeBusinessRules;
        public ContentTypeManager(IContentTypeDal contentTypeDal, IMapper mapper, ContentTypeBusinessRules contentTypeBusinessRules)
        {
            _contentTypeDal = contentTypeDal;
            _mapper = mapper;
            _contentTypeBusinessRules = contentTypeBusinessRules;
        }

        public async Task<CreatedContentTypeResponse> Add(CreateContentTypeRequest createContentTypeRequest)
        {
            await _contentTypeBusinessRules.CheckIfContentTypeNameExists(createContentTypeRequest.Name);
            ContentType contentType = _mapper.Map<ContentType>(createContentTypeRequest);
            var createdContentType = await _contentTypeDal.AddAsync(contentType);
            CreatedContentTypeResponse result = _mapper.Map<CreatedContentTypeResponse>(createdContentType);
            return result;
        }

        public async Task<DeletedContentTypeResponse> Delete(DeleteContentTypeRequest deleteContentTypeRequest)
        {
            ContentType contentType = await _contentTypeDal.GetAsync(predicate: c => c.Id == deleteContentTypeRequest.Id);
            var deletedContentType = await _contentTypeDal.DeleteAsync(contentType, false);
            DeletedContentTypeResponse result = _mapper.Map<DeletedContentTypeResponse>(deletedContentType);
            return result;
        }

        public async Task<IPaginate<GetListContentTypeResponse>> GetListContentType(PageRequest pageRequest)
        {
            var contentType = await _contentTypeDal.GetListAsync(
                orderBy: c => c.OrderBy(c => c.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListContentTypeResponse>>(contentType);
            return result;
        }

        public async Task<UpdatedContentTypeResponse> Update(UpdateContentTypeRequest updateContentTypeRequest)
        {
            await _contentTypeBusinessRules.CheckIfContentTypeNameExists(updateContentTypeRequest.Name);
            ContentType contentType = _mapper.Map<ContentType>(updateContentTypeRequest);
            var updatedContentType = await _contentTypeDal.UpdateAsync(contentType);
            UpdatedContentTypeResponse result = _mapper.Map<UpdatedContentTypeResponse>(updatedContentType);
            return result;
        }
    }
}
