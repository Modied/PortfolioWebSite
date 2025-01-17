using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioRepository.Core.Models
{
    public class AchievedFor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int AchievedId { get; set; }

        public int? CompnyId { get; set; }

        [ForeignKey(nameof(CompnyId))]
        public Company? Company { get; set; }

        public int? CustomerId { get; set; }

        [ForeignKey(nameof(CustomerId))]
        public Customer? Customer { get; set; }


    }
}
