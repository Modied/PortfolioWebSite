using PortfolioRepository.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioService.ViewModels
{
    public class SocialVModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string? icon { get; set; }
        public int PersonalInfoId { get; set; }
        public PersonalInfo PersonalInfo { get; set; }
    }
}
