using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioRepository.Core.Models
{
    public class SocialMedia
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        [Required, Url]
        public string Url { get; set; }

        [StringLength(100)]
        public string? Icon { get; set; }

        public int PersonalInfoId { get; set; }

        [Required]
        public PersonalInfo PersonalInfo { get; set; }

    }
}
