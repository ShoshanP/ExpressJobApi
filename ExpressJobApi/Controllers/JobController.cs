using ExpressJobApi.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExpressJobApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private static List<Job> jobs = new List<Job>();

        // GET: api/<JobController>
        [HttpGet]
        public IEnumerable<Job> Get()
        {
            return jobs;
        }

        // GET api/<JobController>/5
        [HttpGet("{id}")]
        public Job Get(int id)
        {
            return jobs.Where(e => e.id == id).FirstOrDefault(); ;
        }

        // POST api/<JobController>
        [HttpPost]
        public void Post([FromBody] Job value)
        {
            jobs.Add(new Job
            {
                id= value.id,
                type=value.type,
                employer=value.employer,
                experienceYearsRequired=value.experienceYearsRequired
            });
        }

        // PUT api/<JobController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Job value)
        {
            Job jobToUpdate = jobs.Where(e => e.id == id).FirstOrDefault();
            if (jobToUpdate != null)
            {
                jobToUpdate.id = value.id;
                jobToUpdate.type = value.type;
                jobToUpdate.employer = value.employer;
                jobToUpdate.experienceYearsRequired = value.experienceYearsRequired;
                
            
            }
            else
                jobs.Add(new Job
                {
                    id = value.id,
                    type = value.type,
                    employer = value.employer,
                    experienceYearsRequired = value.experienceYearsRequired
                });
        }

            // DELETE api/<JobController>/5
            [HttpDelete("{id}")]
            public void Delete(int id)
            {
            Job j=jobs.Where(e => e.id==id).FirstOrDefault();
            jobs.Remove(j);
            }
        }
    }
