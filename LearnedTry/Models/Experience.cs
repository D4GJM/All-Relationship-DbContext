namespace LearnedTry.Models
{
    public class Experience
    {

        public string ExperienceId { get; set; }
        public string Id { get; set; }
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


     //-----------------------------------------------------------------------------------------

        // ForeignKey References User Table
        public string UserId { get; set; }

        //Navigation property one to one
        public User User { get; set; }
    }
}
