using MehranSmartMap.Core.AutoDiscovery;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace MehranSmartMap.Core.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddMehranSmartMap(this IServiceCollection services, Action<MehranSmartMapOptions> optionsAction = null)
    {
        var options = new MehranSmartMapOptions();
        optionsAction?.Invoke(options);

        var assemblies = options.ScanAssemblies?.ToArray() ?? [Assembly.GetEntryAssembly()!];

        services.AddAutoMapper(cfg =>
        {
            cfg.AddProfile(new AutoDiscoveryProfile(assemblies));
        });

        return services;
    }
}
