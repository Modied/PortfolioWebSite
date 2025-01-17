using Microsoft.AspNetCore.Http;
using PortfolioRepository.Core.Interfaces;
using PortfolioRepository.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Microsoft.AspNetCore.Hosting;

namespace PortfolioService.Services
{
    public class ProfileService : IProfile
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hosting;
        public ProfileService(IUnitOfWork unitOfWork, IWebHostEnvironment hosting)
        {
            _unitOfWork = unitOfWork;
            _hosting = hosting;
        }

        public async Task<PersonalInfo> AddPersonalInfoAsync(PersonalInfo personalInfo)
        {
            var result = await _unitOfWork.PersonalInfoRepository.AddAsync(personalInfo);
            return result;

        }

        public async Task<IEnumerable<PersonalInfo>> GetPersonalInfoAsync()
        {
            return await _unitOfWork.PersonalInfoRepository.GetAllAsync();

        }

        public async Task<PersonalInfo> GetPersonalInfoByIDAsync(int id)
        {
            return await _unitOfWork.PersonalInfoRepository.GetByIDAsync(id);
        }

        public async Task<PersonalInfo> UpdatePersonalInfoAsync(PersonalInfo PersonalInfo)
        {
            return await _unitOfWork.PersonalInfoRepository.UpdateAsync(PersonalInfo, b => b.Id == PersonalInfo.Id);
        }

        public async Task<string> DeletePersonalInfoAsync(int id)
        {
            var result = await _unitOfWork.PersonalInfoRepository.GetByIDAsync(id);
            if (result != null)
            {
                DeletFileName(result.ImageUrl);
                await _unitOfWork.PersonalInfoRepository.DeleteAsync(result);
                return "Delete Done ";

            }
            return null;
        }


        public async Task<string> CopyFileName(IFormFile File)
        {

            if (File != null)
            {
                string filesStorage = Path.Combine(_hosting.WebRootPath, "FilesStorage");
                string fullpath = Path.Combine(filesStorage, File.FileName);
                File.CopyTo(new FileStream(fullpath, FileMode.Create));
                return File.FileName;

            }
            else
                return null;

        }


        public async Task<string> CopyFileName(IFormFile File, string ImageUrl)
        {
            if (File != null)
            {
                string filesStorage = Path.Combine(_hosting.WebRootPath, "FilesStorage");
                string fullpath = Path.Combine(filesStorage, File.FileName);
                string oldName = ImageUrl;

                string oldFullPath = string.Empty;

                if (oldName is not null)
                    oldFullPath = Path.Combine(filesStorage, oldName);

                if (oldFullPath != fullpath)
                {
                    if (System.IO.File.Exists(oldFullPath))
                    {
                        System.IO.File.Delete(oldFullPath);
                    }
                    using (var fileStream = new FileStream(fullpath, FileMode.Create))
                    {
                        File.CopyTo(fileStream);
                    }

                }
                return File.FileName;
            }
            else
                return null;
        }

        public void DeletFileName(string ImageUrl)
        {
            if (!string.IsNullOrEmpty(ImageUrl))
            {
                string filesStorage = Path.Combine(_hosting.WebRootPath, "FilesStorage");
                string oldName = ImageUrl;
                string oldFullPath = string.Empty;

                if (oldName is not null)
                    oldFullPath = Path.Combine(filesStorage, oldName);

                if (File.Exists(oldFullPath))
                {
                    try
                    {

                        File.Delete(oldFullPath);
                    }
                    catch (Exception ex)
                    { }
                }


            }

        }


    }
}