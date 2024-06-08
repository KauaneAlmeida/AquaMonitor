using Microsoft.AspNetCore.Mvc;

namespace aqua_monitor.Controllers;

public class Auth : Controller
{
    [HttpGet]
    public IActionResult LoginView()
    {
        return View("LoginForm");
    }
    
    [HttpGet]
    public IActionResult RegisterView()
    {
        return View("LoginForm");
    }
    
    [HttpPost]
    public IActionResult Login()
    {
        return Ok();
    }
    
    [HttpPost]
    public IActionResult Register()
    {
        return Ok();
    }
}