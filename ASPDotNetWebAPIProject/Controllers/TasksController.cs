using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPDotNetWebAPIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpPost]
        public IActionResult checkNumber([FromBody] UserValueModel user)
        {
            var randomGenerator = new Random();
            int randomNum = randomGenerator.Next(0, 10);
            string result;

            do
            {
                int userNumber = user.userNum;

                if (userNumber >= 0 && userNumber <= 10)
                {
                    if (userNumber == randomNum)
                    {
                        result = "Your number matches with the random number.";
                        break;
                    }
                    else
                    {
                        result = "Numbers do not match.";
                        break;
                    }
                }
                else
                {
                    result = "Invalid Input!";
                }
            } while (true);

            return Ok(result);
        }
        
    }
}
