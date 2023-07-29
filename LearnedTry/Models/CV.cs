namespace LearnedTry.Models
{
    public class CV
    {
        public string CVId { get; set; }
        public string Path { get; set; }
        public string FileName { get; set; }
        public string OriginalFileName { get; set; }
        public string Status { get; set; }
        public DateTime SubmissionDate { get; set; }
        public DateTime ReviewDate { get; set; }
        public DateTime SelectionDate { get; set; }
        public string Recruitment_Remarks { get; set; }

    //-------------------------------------------------------------------------------------

        // ForeignKey References User Table
        public string UserId { get; set; }

        //Navigation property one to one
        public User User { get; set; }

    }
}
