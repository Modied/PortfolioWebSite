using PortfolioRepository.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioService.ViewModels
{
    public class SkillVModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
        public int SkillTypeId { get; set; }
        public SkillType SkillType { get; set; }
        public int PersonalInfoId { get; set; }
        public PersonalInfo PersonalInfo { get; set; }
    }
}
