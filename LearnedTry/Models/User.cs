using System.Net.Mail;
using System.Reflection.Metadata.Ecma335;

namespace LearnedTry.Models
{
    public class User
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string VerificationToken { get; set; }
        public string VerifiedAt { get; set; }
        public string PasswordResetToken { get; set; }
        public string Reset { get; set; }
        public string RegistrationTime { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }

     //------------------------------------------------------------------------

        //Navigation property one to one
        public Applicant Applicant { get; set; }
        public CV CV { get; set; }


        //Navigation property one to many
        public ICollection<Education> Educations { get; set; }

        public ICollection<Experience> Experiences { get; set; }

        //Navigation propperty Many to Many relationship
        public ICollection<UserSkill> UserSkills { get; set; }

        public ICollection<UserCompany> UserCompanies { get; set; }
    }
}
