using CwkSocial.Api.Registrars.Contracts;
using CwkSocial.API.Registrars.Contracts;

namespace CwkSocial.API.Extensions;

public static class RegistrarExtensions
{
    public static void RegisterServices(this WebApplicationBuilder builder, Type scanningType)
    {
        var registrars = GetRegistrars<IWebApplicationBuilderRegistrar>(scanningType);

        registrars
            .ToList()
            .ForEach(reg => reg.RegisterServices(builder));
    }

    public static void RegisterPipelineComponents(this WebApplication app, Type scanningType)
    {
        var registrars = GetRegistrars<IWebApplicationRegistrar>(scanningType);

        registrars
            .ToList()
            .ForEach(reg => reg.RegisterPipelineComponents(app));
    }

    private static IEnumerable<T> GetRegistrars<T>(Type scanningType) 
        where T : IRegistrar => scanningType.Assembly
            .GetTypes()
            .Where(type =>
                type.IsAssignableTo(typeof(T))
                && !type.IsAbstract
                && !type.IsInterface)
            .Select(Activator.CreateInstance)
            .Cast<T>();
}
