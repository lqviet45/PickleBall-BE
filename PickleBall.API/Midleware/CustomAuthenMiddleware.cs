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
        var authHeader = context.Request.Headers["Authorization"].FirstOrDefault();
        var token = authHeader?.Split(" ").Last();
        if (token == null)
        {
            context.Response.StatusCode = 401;
            return;
        }
        var tokenHandler = new JwtSecurityTokenHandler();
        var tokenValue = tokenHandler.ReadJwtToken(token);
        var claims = tokenValue.Claims;
        var identity = new ClaimsIdentity(claims, "custom");
        var principal = new ClaimsPrincipal(identity);
        var ticket = new AuthenticationTicket(principal, "custom");
        context.User = principal;
        
        await _next(context);
    }
}