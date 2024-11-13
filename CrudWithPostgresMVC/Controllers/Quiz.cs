using Microsoft.AspNetCore.Mvc;

namespace CrudWithPostgresMVC.Controllers
{
    public class Quiz : Controller
    {
        [HttpGet]
        public IActionResult SendAnswer() => View();

        [HttpPost]
        public IActionResult SendAnswer(string answer)
        {
            if (answer == "1")
            {
                return Ok("you really gay");
            }
            return BadRequest("You are not gay 😞 ");
        }
    }
}
