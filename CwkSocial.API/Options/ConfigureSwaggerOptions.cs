using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace CwkSocial.API.Options;

public class ConfigureSwaggerOptions : IConfigureOptions<SwaggerGenOptions>
{
    private readonly IApiVersionDescriptionProvider _provider;

    public ConfigureSwaggerOptions(IApiVersionDescriptionProvider provider) 
        => _provider = provider;
    
    public void Configure(SwaggerGenOptions options) => _provider.ApiVersionDescriptions
        .ToList()
        .ForEach(desc =>
        {
            options.SwaggerDoc(desc.GroupName, CreateVersionInfo(desc));
        });
    
    private OpenApiInfo CreateVersionInfo(ApiVersionDescription description) 
        => new()
        {
            Title = "CwkSocial",
            Version = description.ApiVersion.ToString(),
            Description = description.IsDeprecated 
                ? "This API version has been deprecated" 
                : string.Empty
        };
}
