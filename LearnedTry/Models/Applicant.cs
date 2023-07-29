namespace LearnedTry.Models
{
    public class Applicant
    {

        public string ApplicantId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Phone_No { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postal_Code { get; set; }
        public string Country { get; set; }

    //-----------------------------------------------------------------------------------

        // ForeignKey References User Table
        public string UserId { get; set; }

        //Navigation property one to one
        public User User { get; set; }

    }
}
