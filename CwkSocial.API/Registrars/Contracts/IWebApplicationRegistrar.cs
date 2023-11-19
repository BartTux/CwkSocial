using CwkSocial.Api.Registrars.Contracts;

namespace CwkSocial.API.Registrars.Contracts;

public interface IWebApplicationRegistrar : IRegistrar
{
    void RegisterPipelineComponents(WebApplication app);
}
