namespace LearnedTry.Models
{
    public class Skill
    {
        public string SkillId { get; set; }
        public string SkillName { get; set; }


    //------------------------------------------------------------------------------------------

        // ForeignKey References User Table
        public string DepartmentId { get; set; }

        //Navigation property
        public Department Department { get; set; }

        //Navigation propperty Many to Many relationship
        public ICollection<UserSkill> UserSkills { get; set; }

    }
}
