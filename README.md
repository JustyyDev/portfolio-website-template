# Team Portfolio Template

A customizable ASP.NET Core MVC and Razor template for a team portfolio. It includes a shared homepage and three identical, intentionally blank profile pages. No member details are pre-filled.

## Run locally

Install the .NET 8 SDK, then run:

```sh
dotnet run
```

Open the local URL printed in the terminal. Add profile details in `Models/TeamProfiles.cs`; edit shared homepage copy in `Views/Home/Index.cshtml`.

## Publish to a .NET host

Use an ASP.NET Core host that supports .NET 8. Build a release publish directory with:

```sh
dotnet publish -c Release -o ./publish
```

Deploy the contents of `publish/` using the instructions for your hosting provider. GitHub Pages is not suitable for this MVC application because it does not run .NET server code.

## Customize

- Fill in each profile's name, role, image URL, introduction, focus areas, and contact links in `Models/TeamProfiles.cs`.
- Update the shared project description in `Views/Home/Index.cshtml`.
- Adjust colors, spacing, and responsive styles in `wwwroot/css/site.css`.

Each blank profile is available at `/Profiles/profile-one`, `/Profiles/profile-two`, or `/Profiles/profile-three`. All three use the same Razor template. Add or remove a `MemberProfile` in `TeamProfiles.All` to change the number of pages.

## Suggested branch flow

For the class repository's required branches, use `Main` for the finished version, `Release` for release candidates, `Staging` for the pre-release build, `Testing` for QA, `Dev` for integration, and `Features` for shared feature work. Feature work should flow toward `Dev`, then through `Testing`, `Staging`, and `Release` before it reaches `Main`.

This checkout currently uses a lowercase `main` branch. Before creating an uppercase `Main` branch, confirm with the instructor whether the existing branch satisfies the requirement: Git can treat names that differ only by case inconsistently across operating systems, especially on Windows.
