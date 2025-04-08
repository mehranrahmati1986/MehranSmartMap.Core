namespace MehranSmartMap.Core.Infrastructure;

public static class ServiceLocator
{
    public static IServiceProvider Instance =>
        ServiceProvider ?? throw new InvalidOperationException("ServiceProvider is not set");

    public static IServiceProvider ServiceProvider { get; set; }

    public static void SetLocatorProvider(IServiceProvider serviceProvider)
    {
        ServiceProvider = serviceProvider;
    }
}
