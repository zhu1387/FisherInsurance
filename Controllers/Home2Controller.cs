using Microsoft.AspNetCore.Mvc;
public class Home2Controller : Controller
{
    public IActionResult Index()
    {
    return Ok("This is the index of the Home2Controller");
    }
    public IActionResult Quote()
    {
    return Ok("This is the quote of the Home2Controller");
    }
}