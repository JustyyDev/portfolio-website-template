using Microsoft.AspNetCore.Mvc;
using TeamPortfolio.Models;

namespace TeamPortfolio.Controllers;

public class ProfilesController : Controller
{
    public IActionResult Details(string id)
    {
        var profile = TeamProfiles.All.FirstOrDefault(
            member => string.Equals(member.Slug, id, StringComparison.OrdinalIgnoreCase));

        return profile is null ? NotFound() : View(profile);
    }
}