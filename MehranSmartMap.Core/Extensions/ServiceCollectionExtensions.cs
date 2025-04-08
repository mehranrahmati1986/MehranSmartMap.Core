using Microsoft.Extensions.DependencyInjection;

namespace MehranSmartMap.Core.Extensions;

public static class ServiceCollectionExtensions
{
    // متد اکستنشن برای اضافه کردن تنظیمات SmartMap به سرویس‌ها
    public static IServiceCollection AddMehranSmartMap(this IServiceCollection services)
    {
        // اضافه کردن AutoMapper به سرویس‌ها
        services.AddAutoMapper(typeof(ServiceCollectionExtensions).Assembly);

        return services;
    }
}
