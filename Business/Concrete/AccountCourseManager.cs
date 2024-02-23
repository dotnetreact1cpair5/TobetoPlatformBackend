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
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AccountCourseManager : IAccountCourseService
    {

        IAccountCourseDal _accountCourseDal;
        IMapper _mapper;
        public AccountCourseManager(IAccountCourseDal accountCourseDal, IMapper mapper)
        {
            _accountCourseDal = accountCourseDal;
            _mapper = mapper;
        }

        public async Task<CreatedAccountCourseResponse> Add(CreateAccountCourseRequest createAccountCourseRequest)
        {
            AccountCourse accountCourse = _mapper.Map<AccountCourse>(createAccountCourseRequest);
            var createdAccountCourse = await _accountCourseDal.AddAsync(accountCourse);
            CreatedAccountCourseResponse result = _mapper.Map<CreatedAccountCourseResponse>(createdAccountCourse);
            return result;
        }

        public async Task<DeletedAccountCourseResponse> Delete(DeleteAccountCourseRequest deleteAccountCourseRequest)
        {
            AccountCourse accountCourse = await _accountCourseDal.GetAsync(predicate: a => a.Id == deleteAccountCourseRequest.Id);
            var deletedAccountCourse = await _accountCourseDal.DeleteAsync(accountCourse, false);
            DeletedAccountCourseResponse result = _mapper.Map<DeletedAccountCourseResponse>(deletedAccountCourse);
            return result;
        }

        public async Task<IPaginate<GetListAccountCourseResponse>> GetByUserId(int userId, PageRequest pageRequest)
        {
            var accountCourse = await _accountCourseDal.GetListAsync(predicate: a => a.UserId == userId,
                 include: c => c.Include(c => c.User)
                .Include(c => c.Lesson).ThenInclude(c => c.Course).ThenInclude(c => c.Organization)
                .Include(c => c.Lesson).ThenInclude(c => c.Course).ThenInclude(c => c.Category)
                .Include(c => c.Lesson).ThenInclude(c => c.Course).ThenInclude(c => c.ContentType)
                .Include(c => c.Lesson).ThenInclude(c => c.Course).ThenInclude(c => c.PathFile)
                .Include(c => c.Lesson).ThenInclude(c => c.Content)
                .Include(c => c.Lesson).ThenInclude(c => c.Instructor)
                .Include(c => c.Lesson).ThenInclude(c => c.SessionRecord)
                .Include(c => c.Lesson).ThenInclude(c => c.ContentType)
                .Include(c => c.Lesson).ThenInclude(c => c.Category)
                .Include(c => c.Lesson).ThenInclude(c => c.PathFile)

               );
            var result = _mapper.Map<Paginate<GetListAccountCourseResponse>>(accountCourse);
            return result;
                    }

        public async Task<IPaginate<GetListAccountCourseResponse>> GetByCourseId(int courseId)
        {
            var accountCourse = await _accountCourseDal.GetListAsync(
                include:c=>c.Include(c => c.User)
                .Include(c => c.Lesson).ThenInclude(c => c.Course).ThenInclude(c => c.Organization)
                .Include(c => c.Lesson).ThenInclude(c => c.Course).ThenInclude(c => c.Category)
                .Include(c => c.Lesson).ThenInclude(c => c.Course).ThenInclude(c => c.ContentType)
                .Include(c => c.Lesson).ThenInclude(c => c.Course).ThenInclude(c => c.PathFile)
                .Include(c => c.Lesson).ThenInclude(c => c.Content)
                .Include(c => c.Lesson).ThenInclude(c => c.Instructor)
                .Include(c => c.Lesson).ThenInclude(c => c.SessionRecord)
                .Include(c => c.Lesson).ThenInclude(c => c.ContentType)
                .Include(c => c.Lesson).ThenInclude(c => c.Category)
                .Include(c => c.Lesson).ThenInclude(c => c.PathFile)

               );
           var filteredCourses = accountCourse.Items.Where(a => a.Lesson.Course.Lessons.Any(c => c.Course.Id == courseId)).ToList();
            var result = _mapper.Map<Paginate<GetListAccountCourseResponse>>(filteredCourses);
            return result;
        }

        public async Task<IPaginate<GetListAccountCourseResponse>> GetListAccountCourse()
        {
            var accountCourse = await _accountCourseDal.GetListAsync(
                 include: c => c.Include(c => c.User)
                .Include(c => c.Lesson).ThenInclude(c => c.Course).ThenInclude(c => c.Organization)
                .Include(c => c.Lesson).ThenInclude(c => c.Course).ThenInclude(c => c.Category)
                .Include(c => c.Lesson).ThenInclude(c => c.Course).ThenInclude(c => c.ContentType)
                .Include(c => c.Lesson).ThenInclude(c => c.Course).ThenInclude(c => c.Organization)
                .Include(c => c.Lesson).ThenInclude(c => c.Course).ThenInclude(c => c.PathFile)
                .Include(c => c.Lesson).ThenInclude(c => c.PathFile)
                .Include(c => c.Lesson).ThenInclude(c => c.Content)
                .Include(c => c.Lesson).ThenInclude(c => c.SessionRecord)
                .Include(c => c.Lesson).ThenInclude(c => c.Instructor)
                .Include(c => c.Lesson).ThenInclude(c => c.ContentType)
                .Include(c => c.Lesson).ThenInclude(c => c.Category)
                );
            var result = _mapper.Map<Paginate<GetListAccountCourseResponse>>(accountCourse);
            return result;
        }

        public async Task<UpdatedAccountCourseResponse> Update(UpdateAccountCourseRequest updateAccountCourseRequest)
        {
            AccountCourse accountCourse = _mapper.Map<AccountCourse>(updateAccountCourseRequest);
            var updatedCourse = await _accountCourseDal.UpdateAsync(accountCourse);
            UpdatedAccountCourseResponse result = _mapper.Map<UpdatedAccountCourseResponse>(updatedCourse);
            return result;
        }


    }
}
