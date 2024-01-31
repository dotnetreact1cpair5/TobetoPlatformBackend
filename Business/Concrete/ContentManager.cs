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
    public class ContentManager : IContentService
    {

        IContentDal _contentDal;
        IMapper _mapper;
        public ContentManager(IContentDal contentDal, IMapper mapper)
        {
            _contentDal = contentDal;
            _mapper = mapper;
        }

        public async Task<CreatedContentResponse> Add(CreateContentRequest createContentRequest)
        {
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
            Content content = _mapper.Map<Content>(updateContentRequest);
            var updatedContent = await _contentDal.UpdateAsync(content);
            UpdatedContentResponse result = _mapper.Map<UpdatedContentResponse>(updatedContent);
            return result;
        }

    }

}
