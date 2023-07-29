using LearnedTry.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace LearnedTry.Data
{
    public class DataContext:DbContext

    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { 
        
        }

        public DbSet<User> Users{ get; set; }

        public DbSet<CV> CVs{ get; set; }

        public DbSet<Applicant> Applicants{ get; set; }

        public DbSet<Education> Educations { get; set; }

        public DbSet<Experience> Experiences { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<UserSkill> UserSkills { get; set; }

        public DbSet<UserCompany> UserCompanies { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //one to many with one User Many education Qualification
            modelBuilder.Entity<User>()
                .HasKey(u => u.UserId);

            modelBuilder.Entity<Education>()
              .HasKey(e => e.EducationId);

            modelBuilder.Entity<User>()
                .HasMany(e=>e.Educations)
                .WithOne(u=>u.User)
                .HasForeignKey(e=>e.UserId);

          

            //one to many with one User Many Experience Level

            modelBuilder.Entity<User>()
                .HasKey(u => u.UserId);

            modelBuilder.Entity<Experience>()
                .HasKey(e => e.ExperienceId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Experiences)
                .WithOne(u => u.User)
                .HasForeignKey(u => u.UserId);




            //one to many with one department Many Skills

            modelBuilder.Entity<Department>()
               .HasKey(d => d.DepartmentId);

            modelBuilder.Entity<Skill>()
                .HasKey(s => s.SkillId);

            modelBuilder.Entity<Department>()
                .HasMany(s => s.Skills)
                .WithOne(d => d.Department)
                .HasForeignKey(d => d.DepartmentId);


            // Many to Many relationship in Company

            modelBuilder.Entity<UserCompany>()
                .HasKey(uc => new { uc.UserId, uc.CompanyId });

            modelBuilder.Entity<UserCompany>()
                .HasOne(uc=>uc.User)
                .WithMany(u=>u.UserCompanies)
                .HasForeignKey(uc => uc.UserId);

            modelBuilder.Entity<UserCompany>()
                .HasOne(uc => uc.Company)
                .WithMany(u => u.UserCompanies)
                .HasForeignKey(uc => uc.CompanyId);

            // Many to many relationship in Skill

            modelBuilder.Entity<UserSkill>()
                .HasKey(uc => new { uc.UserId, uc.SkillId });

            modelBuilder.Entity<UserSkill>()
                .HasOne(uc => uc.User)
                .WithMany(u => u.UserSkills)
                .HasForeignKey(uc => uc.UserId);

            modelBuilder.Entity<UserSkill>()
                .HasOne(uc => uc.Skill)
                .WithMany(u => u.UserSkills)
                .HasForeignKey(uc => uc.SkillId);

        }

    }
}
