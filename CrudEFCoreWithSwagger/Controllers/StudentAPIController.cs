using CrudEFCoreWithSwagger.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CrudEFCoreWithSwagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAPIController : ControllerBase
    {
        private readonly Entities _entities;

        public StudentAPIController(Entities entities)
        {
            _entities = entities;
        }

        // GET: api/<StudentAPIController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            var getlist = _entities.Students;

            return getlist;
        }


        /* public ActionResult View()
         {

             return Ok(_entities.Students.ToList());

         }*/
        // GET api/<StudentAPIController>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            var getSingleId = _entities.Students.SingleOrDefault(v => v.StudentId == id); 
            
            return getSingleId;
        }

        // POST api/<StudentAPIController>
        [HttpPost]
        public void Post([FromBody] Student student)
        {
            _entities.Students.Add(student);
            _entities.SaveChanges();
        }

        // PUT api/<StudentAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id,[FromBody] Student student)
        {
            student.StudentId = id;
            _entities.Students.Update(student);
            _entities.SaveChanges();
        }

        // DELETE api/<StudentAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _entities.Students.FirstOrDefault(v => v.StudentId == id);
            if (item != null)
            {
                _entities.Students.Remove(item);
                _entities.SaveChanges();
            }
        }
    }
}
