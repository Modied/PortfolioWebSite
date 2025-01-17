using Microsoft.AspNetCore.Http;
using PortfolioRepository.Core.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioService.ViewModels
{
    public class PersonalInfoVModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Bio { get; set; }
        public string About { get; set; }

        public string? ImageUrl { get; set; }
        public IFormFile? file { get; set; }

        public ICollection<SocialMedia>? SocialMedias { get; set; }
        public ICollection<Tool>? Tools { get; set; }
        public ICollection<Education>? Educations { get; set; }
        public ICollection<Company>? Companies { get; set; }
        public ICollection<Customer>? Customers { get; set; }
        public ICollection<Achievement>? Achievements { get; set; }
        public ICollection<Skill>? Skills { get; set; }
    }
}
