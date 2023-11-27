using System.ComponentModel.DataAnnotations;

namespace ExpressJobApi.Entities
{
    public class Job
    {
        public int id { get; set; }
        public TypesJobs type { get; set; }
        public Employer employer { get; set; }

        public int experienceYearsRequired { get; set; }
       

        //public Job()
        //{

        //}
        //public Job(TypesJobs type, Employer employer, int experienceYearsRequired)
        //{
        //    this.type = type;
        //    this.employer = employer;
        //    this.experienceYearsRequired = experienceYearsRequired;

        //}



    }
}
