using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using todo_list.Models;
namespace todo_list.Controllers;

public class AuthManageController : DbConnectController
{
    // Action method for the home page
    public IActionResult Login()
    {
        // Redirect to the Login view
        ConnectToPostgreSQL();
        return View("~/Views/Frontend/Login.cshtml");
    }

    [HttpGet("register")]
    public IActionResult Register()
    {
        // Redirect to the Register view
        return View("~/Views/Frontend/Register.cshtml");
    }
}