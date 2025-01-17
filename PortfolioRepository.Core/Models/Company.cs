using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioRepository.Core.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string Name { get; set; }

        [StringLength(1000)]
        public string? About { get; set; }

        [Required, StringLength(200)]
        public string Position { get; set; }

        [StringLength(1000)]
        public string? AboutJob { get; set; }

        [Required, Range(0, 255)]
        public byte Priority { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [ForeignKey(nameof(PersonalInfo))]
        public int PersonalInfoId { get; set; }

        public PersonalInfo PersonalInfo { get; set; }

    }
}
