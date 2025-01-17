﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioRepository.Core.Models
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [Required, StringLength(50)]
        public string Level { get; set; }

        public int SkillTypeId { get; set; }

        [Required]
        public SkillType SkillType { get; set; }

        public int PersonalInfoId { get; set; }

        [Required]
        public PersonalInfo PersonalInfo { get; set; }

    }
}
