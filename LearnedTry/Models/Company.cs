namespace LearnedTry.Models
{
    public class Company
    {
        public string CompanyId { get; set; }





        //Navigation property many to many
        public ICollection<UserCompany> UserCompanies { get; set; }




    }
}
