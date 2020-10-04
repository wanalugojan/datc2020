using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DATCstudAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SContr : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Student> GetStudents()
        {
           return sRep.getAll();
        }
        [HttpGet("{id}")]
        public Student GetStudentsbyId([FromRoute] int id)
        {
            return sRep.getById(id);
        }
        [HttpPost]
        public string CreateStudent([FromBody] Student student){
            try
            {
                Console.WriteLine(student.ToString());
                sRep.insert(student);
                return "Student created successfully";
            }
            catch(System.Exception error)
            {
                return "Eroare: " + error.Message;
                throw;
            }
        }
        [HttpPut("{id}")]
        public string UpdateStudent([FromRoute]int id, [FromBody] Student student){
            Student updatedStudent = sRep.update(id, student);
            return updatedStudent.ToString();
        }
        [HttpDelete("{id}")]
        public string DeleteStudentById([FromRoute] int id){
            sRep.deleteById(id);
            return "Student removed successfully";
        }
    }
}
