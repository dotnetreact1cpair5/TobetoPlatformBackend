using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
using Business.Dtos.Response.CreatedResponse;
using Business.Dtos.Response.DeletedResponse;
using Business.Dtos.Response.UpdatedResponse;
using Core.Utilities.FileUpload;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PathFileManager : IPathFileService
    {
        private readonly IFileUploadAdapter _fileUploadAdapter;
        IMapper _mapper;
        IPathFileDal _pathDal;

        public PathFileManager(IFileUploadAdapter fileUploadAdapter, IMapper mapper, IPathFileDal pathDal)
        {
            _fileUploadAdapter = fileUploadAdapter;
            _mapper = mapper;
            _pathDal = pathDal;
        }

        public async Task<CreatedPathFileResponse> Add(CreatePathFileRequest createPathRequest)
        {
            PathFile path = _mapper.Map<PathFile>(createPathRequest);

            path.FileName = createPathRequest.File.FileName;
            path.FileUrl = await _fileUploadAdapter.UploadPath(createPathRequest.File);

            PathFile createdPath = await _pathDal.AddAsync(path);
            CreatedPathFileResponse createdPathResponse = _mapper.Map<CreatedPathFileResponse>(createdPath);
            return createdPathResponse;
        }

        public async Task<DeletedPathFileResponse> Delete(DeletePathFileRequest deletePathRequest)
        {
            PathFile path = await _pathDal.GetAsync(f => f.Id == deletePathRequest.Id);
            await _fileUploadAdapter.DeletePath(path.FileUrl);

            await _pathDal.DeleteAsync(path);
            DeletedPathFileResponse deletedPathResponse = _mapper.Map<DeletedPathFileResponse>(path);
            return deletedPathResponse;
        }

        public async Task<UpdatedPathFileResponse> Update(UpdatePathFileRequest updatePathRequest)
        {
            PathFile path = await _pathDal.GetAsync(predicate: f => f.Id == updatePathRequest.Id);
            //  path = _mapper.Map<PathFile>(updatePathRequest);
            path = _mapper.Map(updatePathRequest, path);
            path.FileUrl = await _fileUploadAdapter.UpdatePath(updatePathRequest.File, path.FileUrl);
            await _pathDal.UpdateAsync(path);
            UpdatedPathFileResponse updatedPathResponse = _mapper.Map<UpdatedPathFileResponse>(path);
            return updatedPathResponse;
        }
    }
}
