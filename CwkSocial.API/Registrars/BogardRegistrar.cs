using CwkSocial.API.Registrars.Contracts;
using CwkSocial.Application.UserProfiles.Queries;

namespace CwkSocial.Api.Registrars;

public class BogardRegistrar : IWebApplicationBuilderRegistrar
{
    public void RegisterServices(WebApplicationBuilder builder)
    {
        builder.Services.AddAutoMapper(typeof(Program), typeof(GetAllUserProfilesQuery));

        builder.Services.AddMediatR(config => 
            config.RegisterServicesFromAssemblyContaining(typeof(GetAllUserProfilesQuery))
        );
    }
}
