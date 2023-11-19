﻿using CwkSocial.API.Options;
using CwkSocial.API.Registrars.Contracts;

namespace CwkSocial.API.Registrars;

public class SwaggerRegistrar : IWebApplicationBuilderRegistrar
{
    public void RegisterServices(WebApplicationBuilder builder)
    {
        builder.Services.AddSwaggerGen();
        builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();
    }
}
