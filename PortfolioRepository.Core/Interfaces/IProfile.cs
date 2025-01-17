
using Microsoft.AspNetCore.Http;
using PortfolioRepository.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioRepository.Core.Interfaces
{
    public interface IProfile
    {
        Task<IEnumerable<PersonalInfo>> GetPersonalInfoAsync();
        Task<PersonalInfo> GetPersonalInfoByIDAsync(int id);
        Task<PersonalInfo> AddPersonalInfoAsync(PersonalInfo personalInfo);
        Task<PersonalInfo> UpdatePersonalInfoAsync(PersonalInfo newPersonalInfo);
        Task<string> DeletePersonalInfoAsync(int id);

        Task<string> CopyFileName(IFormFile File);
        Task<string> CopyFileName(IFormFile File, string ImageUrl);
        void DeletFileName(string ImageUrl);

    }
}
