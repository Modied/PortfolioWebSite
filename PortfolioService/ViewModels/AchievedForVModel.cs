using PortfolioRepository.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioService.ViewModels
{
    public class AchievedForVModel
    {
        public int Id { get; set; }

        public int AchievedId { get; set; }

        public string? CompnyId { get; set; }
        public Company? Company { get; set; }
        public string? CustomerId { get; set; }
        public Customer? Customer { get; set; }
    }
}
