using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
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
    public class ContentCoursePageManager : IContentCoursePageService
    {

        IContentCoursePageDal _contentCoursePageDal;
        IMapper _mapper;
        public ContentCoursePageManager(IContentCoursePageDal contentCoursePageDal, IMapper mapper)
        {
            _contentCoursePageDal = contentCoursePageDal;
            _mapper = mapper;
        }

        public async Task<CreatedContentCoursePageResponse> Add(CreateContentCoursePageRequest createContentCoursePageRequest)
        {
            ContentCoursePage contentCoursePage = _mapper.Map<ContentCoursePage>(createContentCoursePageRequest);
            var createdContentCoursePage = await _contentCoursePageDal.AddAsync(contentCoursePage);
            CreatedContentCoursePageResponse result = _mapper.Map<CreatedContentCoursePageResponse>(createdContentCoursePage);
            return result;
        }

        public async Task<DeletedContentCoursePageResponse> Delete(DeleteContentCoursePageRequest deleteContentCoursePageRequest)
        {
            ContentCoursePage contentCoursePage = await _contentCoursePageDal.GetAsync(predicate: a => a.Id == deleteContentCoursePageRequest.Id);
            var deletedContentCoursePage = await _contentCoursePageDal.DeleteAsync(contentCoursePage, false);
            DeletedContentCoursePageResponse result = _mapper.Map<DeletedContentCoursePageResponse>(deletedContentCoursePage);
            return result;
        }

        public async Task<GetListContentCoursePageResponse> GetById(int contentCoursePageId)
        {
            var contentCoursePage = await _contentCoursePageDal.GetAsync(predicate: a => a.Id == contentCoursePageId);
            var result = _mapper.Map<GetListContentCoursePageResponse>(contentCoursePage);
            return result;
        }

        public async Task<IPaginate<GetListContentCoursePageResponse>> GetListContentCoursePage()
        {
            var contentCoursePage = await _contentCoursePageDal.GetListAsync(
                include: c => c.Include(c => c.Content));
            var result = _mapper.Map<Paginate<GetListContentCoursePageResponse>>(contentCoursePage);
            return result;
        }

        public async Task<UpdatedContentCoursePageResponse> Update(UpdateContentCoursePageRequest updateContentCoursePageRequest)
        {
            ContentCoursePage contentCoursePage = _mapper.Map<ContentCoursePage>(updateContentCoursePageRequest);
            var updatedContentCoursePage = await _contentCoursePageDal.UpdateAsync(contentCoursePage);
            UpdatedContentCoursePageResponse result = _mapper.Map<UpdatedContentCoursePageResponse>(updatedContentCoursePage);
            return result;
        }


    }


}
