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
    public class ContentManager : IContentService
    {

        IContentDal _contentDal;
        IMapper _mapper;
        ContentBusinessRules _contentBusinessRules;
        public ContentManager(IContentDal contentDal, IMapper mapper, ContentBusinessRules contentBusinessRules)
        {
            _contentDal = contentDal;
            _mapper = mapper;
            _contentBusinessRules = contentBusinessRules;
        }

        public async Task<CreatedContentResponse> Add(CreateContentRequest createContentRequest)
        {
            await _contentBusinessRules.CheckIfContentNameExists(createContentRequest.Name);
            Content content = _mapper.Map<Content>(createContentRequest);
            var createdContent = await _contentDal.AddAsync(content);
            CreatedContentResponse result = _mapper.Map<CreatedContentResponse>(createdContent);
            return result;
        }

        public async Task<DeletedContentResponse> Delete(DeleteContentRequest deleteContentRequest)
        {
            Content content = await _contentDal.GetAsync(predicate: a => a.Id == deleteContentRequest.Id);
            var deletedContent = await _contentDal.DeleteAsync(content, false);
            DeletedContentResponse result = _mapper.Map<DeletedContentResponse>(deletedContent);
            return result;
        }

        public async Task<GetListContentResponse> GetById(int contentId)
        {
            var content = await _contentDal.GetAsync(predicate: a => a.Id == contentId);
            var result = _mapper.Map<GetListContentResponse>(content);
            return result;
        }

        public async Task<IPaginate<GetListContentResponse>> GetListContent()
        {
            var content = await _contentDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetListContentResponse>>(content);
            return result;
        }

        public async Task<UpdatedContentResponse> Update(UpdateContentRequest updateContentRequest)
        {
            await _contentBusinessRules.CheckIfContentNameExists(updateContentRequest.Name);
            Content content = _mapper.Map<Content>(updateContentRequest);
            var updatedContent = await _contentDal.UpdateAsync(content);
            UpdatedContentResponse result = _mapper.Map<UpdatedContentResponse>(updatedContent);
            return result;
        }

    }

}
