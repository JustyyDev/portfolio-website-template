namespace TeamPortfolio.Models;

public static class TeamProfiles
{
    public static IReadOnlyList<MemberProfile> All { get; } = new[]
    {
        new MemberProfile("profile-one", "", "", "", "", Array.Empty<string>(), "", ""),
        new MemberProfile("profile-two", "", "", "", "", Array.Empty<string>(), "", ""),
        new MemberProfile("profile-three", "", "", "", "", Array.Empty<string>(), "", "")
    };
}