using System.ComponentModel.DataAnnotations;

namespace ExpressJobApi.Entities
{
   
   
    public class Employer
    {

        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string city { get; set; }
        public bool status { get; set; }





        //public Employer()
        //{

        //}
        //public Employer(string name, EmailAddressAttribute email, string city)
        //{
        //    this.name = name;
        //    this.email = email;
        //    this.city = city;


        //}

    }
}
