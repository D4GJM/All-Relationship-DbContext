namespace LearnedTry.Models
{
    public class Education
    {

        public string EducationId { get; set; }
        public string CurrentStatus { get; set; }
        public string Qulification { get; set; }
        public string InsituteName { get; set; }
        public DateTime AddQualifiction { get; set; }


     //---------------------------------------------------------------------------------------


        // ForeignKey References User Table
        public string UserId { get; set; }

        //Navigation property one to Many
        public User User { get; set; }
    }
}
