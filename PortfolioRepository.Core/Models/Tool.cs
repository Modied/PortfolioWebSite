using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioRepository.Core.Models
{
    public class Tool
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [AllowNull]
        public string Type { get; set; }

        [Range(0, 255)]
        public byte Priority { get; set; }

        public int PersonalInfoId { get; set; }

        [Required]
        public PersonalInfo PersonalInfo { get; set; }

    }
}
