using PortfolioRepository.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioService.ViewModels
{
    public class CompanyVModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string? About { get; set; }
        public string Position { get; set; }
        public string? AboutJob { get; set; }
        public byte Priority { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int PersonalInfoId { get; set; }
        public PersonalInfo PersonalInfo { get; set; }
    }
}
