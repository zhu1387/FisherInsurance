using Microsoft.AspNetCore.Mvc;
public class CustomerCareController : Controller
{
    public IActionResult Index()
    {
    return Ok("This is the index of the CustomerCareController");
    }
    public IActionResult Claims ()
    {
    return Ok("This is the claims of the CustomerCareController");
    }
}