﻿namespace N65.IdentityVerificatoin.Api.Configurations;

public static partial class HostConfiguration
{
    public static ValueTask<WebApplicationBuilder> ConfigureAsync(this WebApplicationBuilder builder)
    {
        builder
            .AddIdentityInfrastructure()
            .AddNotificationInfrastructure()
            .AddDevTools()
            .AddExposers();

        return new(builder);
    }

    public static ValueTask<WebApplication> ConfigureAsync(this WebApplication app)
    {
        app
            .UseIdentityInfrastructure()
            .UseDevTools()
            .UseExposers();

        return new(app);
    }
}
