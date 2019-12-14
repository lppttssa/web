using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _3._4Formula;
using Microsoft.AspNetCore.Builder;
public static class TokenExtensions
{
    public static IApplicationBuilder UseToken(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<TokenMiddleware>();
    }
}
