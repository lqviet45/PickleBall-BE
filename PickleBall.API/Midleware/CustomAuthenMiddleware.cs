using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace PickleBall.API.Midleware;

public class CustomAuthenMiddleware
{
    private readonly RequestDelegate _next;

    public CustomAuthenMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        var authHeader = context.Request.Headers.Authorization.FirstOrDefault();
        if (authHeader is null)
        {
            await _next(context);
            return;
        }
        var token = authHeader?.Split(" ").Last();
        if (token == null)
        {
            context.Response.StatusCode = 401;
            return;
        }
        var tokenHandler = new JwtSecurityTokenHandler();
        var tokenValue = tokenHandler.ReadJwtToken(token);
        if (tokenValue.ValidTo < DateTime.UtcNow)
        {
            context.Response.StatusCode = 401;
            await context.Response.WriteAsync("Token expired");
            return;
        }
        if (tokenValue.Claims.All(c => c.Type != "Role"))
        {
            context.Response.StatusCode = 403;
            await context.Response.WriteAsync("Invalid token");
            return;
        }
        var claims = tokenValue.Claims.ToList();
        claims.Add(new Claim(ClaimTypes.Role, tokenValue.Claims.First(c => c.Type == "Role").Value));
        var identity = new ClaimsIdentity(claims, "custom");
        var principal = new ClaimsPrincipal(identity);
        var ticket = new AuthenticationTicket(principal, "custom");
        context.User = principal;
        
        await _next(context);
    }
}