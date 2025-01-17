﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioRepository.Core.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        public string? About { get; set; }

        [Range(0, 255)]
        public byte Priority { get; set; }

        [Required, StringLength(500)]
        public string Description { get; set; }

        public int PersonalInfoId { get; set; }

        [Required]
        public PersonalInfo PersonalInfo { get; set; }

    }
}
