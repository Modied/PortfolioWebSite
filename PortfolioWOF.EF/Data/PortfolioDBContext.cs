using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using PortfolioRepository.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioWOF.EF.Data
{
    public class PortfolioDBContext : DbContext
    {
        public PortfolioDBContext(DbContextOptions<PortfolioDBContext> options) : base(options) { }


        public DbSet<PersonalInfo> PersonalInfos { get; set; }
        public DbSet<Achievement> Achievements { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillType> SkillTypes { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<EducationType> educationTypes { get; set; }
        public DbSet<Tool> Tools { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PersonalInfo>().HasData(

                new PersonalInfo()
                {
                    Id = 2,
                    Name = "Jane Smith",
                    Email = "janesmith@example.com",
                    Phone = "0987654321",
                    Address = "456 Elm St",
                    Bio = "Graphic Designer",
                    About = "Loves creativity and design",
                    ImageUrl = null,

                }



              );

        }
    }
}
