using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BizApp.Authentication
{
    public class AuthController : Controller
    {
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CookieLogin()
        {
            // Generate the claims
            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, "John Patton"));
            claims.Add(new Claim(ClaimTypes.Role, "Contributor"));

            var principal = new ClaimsPrincipal(new ClaimsIdentity(claims, "Auth"));

            await HttpContext.SignInAsync("Auth", principal).ConfigureAwait(false);

            return Redirect("/");
        }
    }
}
