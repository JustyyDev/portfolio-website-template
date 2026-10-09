using Microsoft.AspNetCore.Mvc;
using TeamPortfolio.Models;

namespace TeamPortfolio.Controllers;

public class ProfilesController : Controller
{
    [HttpGet("/Profiles/{id}")]
    public IActionResult Details(string id)
    {
        var profile = TeamProfiles.All.FirstOrDefault(
            member => string.Equals(member.Slug, id, StringComparison.OrdinalIgnoreCase));

        return profile is null ? NotFound() : View(profile);
    }
}