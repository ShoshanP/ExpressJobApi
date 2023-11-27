using System.ComponentModel.DataAnnotations;
public enum TypesJobs
{
    thecnut, cleaner, CPA, contractor, teacher, KindergartenTeacher, Director, secretary, gardener, librarian, author }
namespace ExpressJobApi.Entities
{
    
    
    public class Employee
    {

        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        //public string CV { get; set; }
        public int experienceYears { get; set; }
        public TypesJobs typeJob { get; set; }
        public bool status { get; set; }
        //public Employee()
        //{

        //}
        //public Employee(string name, EmailAddressAttribute email,int experienceYears, TypesJobs typeJob)

        //{
        //    this.name = name;
        //    this.email = email;
        //    this.experienceYears = experienceYears;
        //    this.typeJob = typeJob;

        //}

    }
}
