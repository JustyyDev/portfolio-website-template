namespace TeamPortfolio.Models;

public sealed record MemberProfile(
    string Slug,
    string Name,
    string Role,
    string ImageUrl,
    string Introduction,
    string[] FocusAreas,
    string Email,
    string GithubUrl);