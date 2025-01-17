using PortfolioRepository.Core.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioService.ViewModels
{/*
  
  
   
  */
    public class ToolVModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [AllowNull]
        public string Type { get; set; }
        public byte Priority { get; set; }
        public int PersonalInfoId { get; set; }
        public PersonalInfo PersonalInfo { get; set; }
    }
}
