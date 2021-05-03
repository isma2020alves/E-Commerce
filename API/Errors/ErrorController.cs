using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Errors
{
    [Route("errors/{code}")]
    public class ErrorController : BaseApiController
    {
       public IActionResult Error(int code)
       {
           return new ObjectResult(new ApiResponse(code));
       } 
    }
}