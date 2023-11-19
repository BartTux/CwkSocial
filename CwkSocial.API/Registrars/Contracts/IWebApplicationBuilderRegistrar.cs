using CwkSocial.Api.Registrars.Contracts;

namespace CwkSocial.API.Registrars.Contracts;

public interface IWebApplicationBuilderRegistrar : IRegistrar
{
    void RegisterServices(WebApplicationBuilder builder);
}
