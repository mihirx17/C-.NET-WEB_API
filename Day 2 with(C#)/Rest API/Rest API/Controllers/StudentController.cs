using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REST_API.Models;

namespace REST_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
        
    {
        private readonly ILogger<StudentController> _logger;

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
        }

        public static List<Student_info> students = new List<Student_info>()
        { new Student_info{Id=1,Name="Mihir Gupta" },
            new Student_info{Id=2,Name="Tony" },
            new Student_info{Id=3,Name="Hulk" },
            new Student_info{Id=4,Name="IRON MAN" },
        };
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult getAll_Student()
            
        {
            _logger.LogInformation("GET METHOD HAS BEEN CALLED");
            return Ok(students);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult get_Student(int id)
        {
            _logger.LogInformation("GET METHOD BY ID HAS BEEN CALLED");
            if (id == 0)
            {
                return NotFound();
            }
            var GetvaluesByID = students.FirstOrDefault(x => x.Id == id);
            if (GetvaluesByID == null)
            {
                return BadRequest();
            }
            return Ok(GetvaluesByID);
        }
            [HttpPost]
            [ProducesResponseType(StatusCodes.Status200OK)] // Indicates successful operation
            [ProducesResponseType(StatusCodes.Status400BadRequest)] // Indicates bad request
            [ProducesResponseType(StatusCodes.Status500InternalServerError)] // Indicates server error
            [ProducesResponseType(StatusCodes.Status404NotFound)] // Indicates resource not found
            public ActionResult CreateValues([FromBody] Student_info student)
            {
            _logger.LogInformation("POST METHOD HAS BEEN CALLED");
            // Check if the student object is null
            if (student == null)
                {
                    // If null, return a BadRequest response
                    return BadRequest();
                }

                // Generate a new unique ID for the student
                student.Id = students.OrderByDescending(x => x.Id).FirstOrDefault()?.Id + 1 ?? 1;

                // Add the student to the collection
                students.Add(student);

                // Return a success message along with the response
                return Ok($"Successfully added");
            }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _logger.LogInformation("DELETE METHOD HAS BEEN CALLED");
            // Check if ID is less than or equal to 0
            if (id == 0)
            {
                return NotFound();
            }

            // Find the student by ID
            var studentToDelete = students.FirstOrDefault(student => student.Id == id);

            // Check if the student exists
            if (studentToDelete == null)
            {
                return NotFound();
            }

            // Remove the student from the list
            students.Remove(studentToDelete);

            // Return a success status code
            return Ok($"Successfully Deleted..");
        }
        [HttpPut]
        public ActionResult UpdateBYId(int id, [FromBody] Student_info student)
        {
            _logger.LogInformation("PUT METHOD HAS BEEN CALLED");
            if (student==null)
            {
                return BadRequest();
            }
            students[student.Id] = student;
            return Ok($"Successfully Updated");
        }


    }
}

