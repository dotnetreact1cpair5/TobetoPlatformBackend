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
    public class StudentClassManager : IStudentClassService
    {

        IStudentClassDal _StudentClassDal;
        IMapper _mapper;
        public StudentClassManager(IStudentClassDal StudentClassDal, IMapper mapper)
        {
            _StudentClassDal = StudentClassDal;
            _mapper = mapper;
        }

        public async Task<CreatedStudentClassResponse> Add(CreateStudentClassRequest createStudentClassRequest)
        {
            StudentClass studentClass = _mapper.Map<StudentClass>(createStudentClassRequest);
            var createdStudentClass = await _StudentClassDal.AddAsync(studentClass);
            CreatedStudentClassResponse result = _mapper.Map<CreatedStudentClassResponse>(createdStudentClass);
            return result;
        }

        public async Task<DeletedStudentClassResponse> Delete(DeleteStudentClassRequest deleteStudentClassRequest)
        {
            StudentClass studentClass = _mapper.Map<StudentClass>(deleteStudentClassRequest);
            var deletedStudentClass = await _StudentClassDal.DeleteAsync(studentClass, false);
            DeletedStudentClassResponse result = _mapper.Map<DeletedStudentClassResponse>(deletedStudentClass);
            return result;
        }

        public async Task<IPaginate<GetListStudentClassResponse>> GetListStudentClass()
        {
            var studentClass = await _StudentClassDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetListStudentClassResponse>>(studentClass);
            return result;
        }

        public async Task<UpdatedStudentClassResponse> Update(UpdateStudentClassRequest updateStudentClassRequest)
        {
            StudentClass studentClass = _mapper.Map<StudentClass>(updateStudentClassRequest);
            var updatedStudentClass = await _StudentClassDal.UpdateAsync(studentClass);
            UpdatedStudentClassResponse result = _mapper.Map<UpdatedStudentClassResponse>(updatedStudentClass);
            return result;
        }
    }
}
