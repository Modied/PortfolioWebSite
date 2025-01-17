using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioRepository.Core.Models
{
    public class PersonalInfo
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, Phone]
        public string Phone { get; set; }

        [Required, StringLength(200)]
        public string Address { get; set; }

        public string Bio { get; set; }

        public string About { get; set; }
        public string? ImageUrl { get; set; }

        public ICollection<SocialMedia>? SocialMedias { get; set; }
        public ICollection<Tool>? Tools { get; set; }
        public ICollection<Education>? Educations { get; set; }
        public ICollection<Company>? Companies { get; set; }
        public ICollection<Customer>? Customers { get; set; }
        public ICollection<Achievement>? Achievements { get; set; }
        public ICollection<Skill>? Skills { get; set; }

    }
}
