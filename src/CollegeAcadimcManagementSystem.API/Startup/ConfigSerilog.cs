using Serilog;

namespace CollegeAcadimcManagementSystem.API.Startup;

public static class ConfigSerilog
{
    public static void UseSerilogLoggging(this IHostBuilder host)
    {
        host.UseSerilog((context, services, configuration) =>
        configuration
        .ReadFrom.Configuration(context.Configuration)
        .ReadFrom.Services(services)
        .Enrich.FromLogContext());
    }
}
