namespace LearnedTry.Models
{
    public class UserCompany
    {
        public string UserCompanyId { get; set; }


        //Composite Key References Using Both Tables UserId and SkillId
        public string UserId { get; set; }
        public string CompanyId { get; set; }


        //Navigation property
        public User User { get; set; }
        public Company Company { get; set; }
    }
}
