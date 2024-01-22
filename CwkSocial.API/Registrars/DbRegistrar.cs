using CwkSocial.API.Registrars.Contracts;
using CwkSocial.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace CwkSocial.Api.Registrars;

public class DbRegistrar : IWebApplicationBuilderRegistrar
{
    public void RegisterServices(WebApplicationBuilder builder)
    {
        var connectionString = builder.Configuration.GetConnectionString("Default");
        builder.Services
            .AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));
    }
}
