namespace LearnedTry.Models
{
    public class UserSkill
    {
        public string UserSkillId { get; set; }


        //Composite Key References Using Both Tables UserId and SkillId

        public string UserId { get; set; }

        public string SkillId { get; set; }

        //Navigation property

        public User User { get; set; }
        public Skill Skill { get; set; }




    }
}
