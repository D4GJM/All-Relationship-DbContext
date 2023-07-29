namespace LearnedTry.Models
{
    public class Department
    {
        public string DepartmentId { get; set; }
        public string DepartmentName { get; set; }




   //--------------------------------------------------------------------------------------

        //Navigation property one to many
        public ICollection<Skill> Skills { get; set; }


    }
}
