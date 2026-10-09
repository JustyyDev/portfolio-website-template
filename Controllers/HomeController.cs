using Microsoft.AspNetCore.Mvc;
using TeamPortfolio.Models;

namespace TeamPortfolio.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View(TeamProfiles.All);

    public IActionResult Error() => View();
}