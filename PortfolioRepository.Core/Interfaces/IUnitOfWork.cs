
using PortfolioRepository.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioRepository.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<PersonalInfo> PersonalInfoRepository { get; }

        int complet();
    }
}
