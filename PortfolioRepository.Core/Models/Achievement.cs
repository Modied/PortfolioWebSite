using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioRepository.Core.Models
{
    public class Achievement
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Title { get; set; }

        [Required, StringLength(500)]
        public string Features { get; set; }

        [Required, Range(0, 255)]
        public byte Priority { get; set; }

        [Required, StringLength(1000)]
        public string Description { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [ForeignKey("PersonalInfo")]
        public int PersonalInfoId { get; set; }

        public PersonalInfo PersonalInfo { get; set; }

        public ICollection<AchievedFor> AchievedFors { get; set; } = new List<AchievedFor>();


    }
}
