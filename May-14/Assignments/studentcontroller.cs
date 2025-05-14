using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        public string  Index()
        {
            return "This is the Index Action";
        }

        public string StudentName()
        {
            return "Student Name is Pranesh";
        }

        public string StudentPhone()
        {
            return "Student Phone 8787878787";
        }
    }
}
