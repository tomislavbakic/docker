using Microsoft.AspNetCore.Mvc;
using SkiSchool.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SkiSchool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorsController : ControllerBase
    {
        // GET: api/<InstructorsController>
        private ApiDbContext _context;

        public InstructorsController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Instructor>> Get()
        {
            return _context.Instructors.ToList();
        }

        // GET api/<InstructorsController>/5
        [HttpGet("{id}")]
        public String Get(long id)
        {
            return _context.Instructors.Find(id).UserName;
        }

        [Route("add")]
        [HttpPost]
        public string InsertNewInstructor([FromBody]Instructor instructor)
        {
            try
            {
          
                Instructor inst = new Instructor();

                inst.FirstName = instructor.FirstName;
                inst.LastName = instructor.LastName;
                inst.Password = instructor.Password;
                inst.PhoneNumber = instructor.PhoneNumber;
                inst.UserName = instructor.UserName;


                _context.Add(inst);
                _context.SaveChanges();

                return "ok";
            } catch(Exception e)
            {
                return e.ToString();
            }
           
        }


        [HttpDelete("{id}")]
        public void DeleteInstructor(long id)
        {
            Instructor i = _context.Instructors.Find(id);
            _context.Instructors.Remove(i);
            _context.SaveChanges();
        }

    }
}
