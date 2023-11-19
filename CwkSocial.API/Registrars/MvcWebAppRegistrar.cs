using CwkSocial.API.Registrars.Contracts;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace CwkSocial.API.Registrars;

public class MvcWebAppRegistrar : IWebApplicationRegistrar
{
    public void RegisterPipelineComponents(WebApplication app)
    {
        app.UseSwagger();
        app.UseSwaggerUI(options =>
        {
            var provider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();

            provider.ApiVersionDescriptions
                .ToList()
                .ForEach(desc =>
                    options.SwaggerEndpoint($"/swagger/{desc.GroupName}/swagger.json",
                        desc.ApiVersion.ToString())
                 );
        });

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
    }
}
