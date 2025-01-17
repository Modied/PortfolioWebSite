using PortfolioRepository.Core.Interfaces;
using PortfolioRepository.Core.Models;
using PortfolioWOF.EF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioWOF.EF.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PortfolioDBContext _dbContext;
        public IBaseRepository<PersonalInfo> PersonalInfoRepository { get; private set; }

        public UnitOfWork(PortfolioDBContext dbcontext)
        {
            _dbContext = dbcontext;
            PersonalInfoRepository = new BaseRepository<PersonalInfo>(_dbContext);
        }

        public int complet()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
