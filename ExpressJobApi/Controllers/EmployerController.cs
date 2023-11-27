using ExpressJobApi.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExpressJobApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployerController : ControllerBase
    {
        private static List<Employer> employers = new List<Employer>();
        private static int countId = 0;
        // GET: api/<EmployerController>
        [HttpGet]
        public IEnumerable<Employer> Get()
        {
            return employers;
        }

        // GET api/<EmployerController>/5
        [HttpGet("{id}")]
        public Employer Get(int id)
        {
            return employers.Where(e => e.id == id).FirstOrDefault();
        }

        // POST api/<EmployerController>
        [HttpPost]
        public void Post([FromBody] Employer newEmployer)
        {
            employers.Add(new Employer
            {
                id = ++countId,
                name = newEmployer.name,
                email = newEmployer.email,
                //CV = newEmployer.CV,
                city = newEmployer.city,
                status = true,

            }) ;
        }


        // PUT api/<EmployerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employer emp)
        {
            Employer empToUpdate = employers.Where(e => e.id == id).FirstOrDefault();
            if (empToUpdate != null)
            {
                empToUpdate.id = emp.id;
                empToUpdate.name = emp.name;
                empToUpdate.email = emp.email;
                empToUpdate.city = emp.city;
                empToUpdate.status = emp.status;


            }
            else
                employers.Add(new Employer
                {
                    id = ++countId,
                    name = emp.name,
                    email = emp.email,
                    city = emp.city,
                    status = true,

                }) ;
        }
        [HttpPut("{id}/status")]
        public void PutStatus(int id)
        {
            Employer e = employers.Where(e => e.id == id).FirstOrDefault();
            if (e != null)
            {
                if (e.status)
                    e.status = false;
                else e.status = true;
            }
        }

        // DELETE api/<EmployerController>/5

    }
}
