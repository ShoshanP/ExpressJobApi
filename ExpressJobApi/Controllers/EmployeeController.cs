using ExpressJobApi.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExpressJobApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employee = new List<Employee>() ;
        private static int countId = 0;
        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return employee;
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return employee.Where(e => e.id == id).FirstOrDefault();
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] Employee newEmployee)
        {
            employee.Add(new Employee
            {
                id = ++countId,
                name = newEmployee.name,
                email = newEmployee.email,
                //CV = newEmployee.CV,
                experienceYears = newEmployee.experienceYears,
                typeJob = newEmployee.typeJob,
                status = true
            });
        }
       

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee emp)
        {
            Employee empToUpdate = employee.Where(e => e.id == id).FirstOrDefault();
            if (empToUpdate != null)
            {
                empToUpdate.id = emp.id;
                empToUpdate.name = emp.name;
                empToUpdate.email = emp.email;
                //empToUpdate.CV = emp.CV;
                empToUpdate.experienceYears = emp.experienceYears;
                empToUpdate.typeJob = emp.typeJob;
                empToUpdate.status = emp.status;
            }
            else
                employee.Add(new Employee
                {
                    id = ++countId,
                    name = emp.name,
                    email = emp.email,
                    //CV = emp.CV,
                    experienceYears = emp.experienceYears,
                    typeJob = emp.typeJob
                });
        }
        [HttpPut("{id}/status")]
        public void PutStatus(int id )
        {
            Employee e=employee.Where(e=>e.id==id).FirstOrDefault();
            if (e!=null)
            {
                if(e.status)
                    e.status= false;
                else e.status= true;
            }
        }

        // DELETE api/<EmployeeController>/5

    }
}
