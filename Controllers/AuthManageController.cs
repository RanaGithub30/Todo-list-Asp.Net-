using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using todo_list.Models;
// namespace todo_list.Controllers;
// using todo_list.Data; 

namespace todo_list.Controllers
{
public class AuthManageController : Controller
{

    // private readonly TodoDbContext _context;

    // public AuthManageController(TodoDbContext context)
    // {
    //     _context = context;
    // }

    // Action method for the home page
    public IActionResult Login()
    {
        // Redirect to the Login view
        // ConnectToPostgreSQL();
        return View("~/Views/Frontend/Login.cshtml");
    }

    [HttpGet("register")]
    public IActionResult Register()
    {
        // Redirect to the Register view
        return View("~/Views/Frontend/Register.cshtml");
    }

    // [HttpPost("register-action")]
    // public IActionResult RegisterAction(string username, string password, string email)
    // {
    //     // Validate input if needed
    //         if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
    //         {
    //             // Handle invalid input (e.g., return a view with error message)
    //             return View("Error");
    //         }

    //     // Create a new User instance
    //         var user = new User
    //         {
    //             Username = username,
    //             Password = password,
    //             Email = email
    //         };

    //         // Save the user to the database
    //         _context.Users.Add(user);
    //         _context.SaveChanges();

    //     return RedirectToAction("Login");;
    // }
}
}