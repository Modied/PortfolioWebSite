using PortfolioRepository.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioService.ViewModels
{
    public class AchievementVModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Features { get; set; }
        public byte Priority { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int PersonalInfoId { get; set; }
        public PersonalInfo PersonalInfo { get; set; }

        public ICollection<AchievedFor> achievedFors { get; set; }
    }
}
