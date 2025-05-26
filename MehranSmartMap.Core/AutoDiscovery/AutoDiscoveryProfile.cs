using AutoMapper;
using MehranSmartMap.Core.BaseMap;
using MehranSmartMap.Core.Infrastructure;
using System.Reflection;

namespace MehranSmartMap.Core.AutoDiscovery;

/// <summary>
/// یافتن و ساختن اتوماتیک مپر ها
/// </summary>
public class AutoDiscoveryProfile : Profile
{
    public AutoDiscoveryProfile(Assembly[] assemblies)
    {
        foreach (var assembly in assemblies)
        {
            IEnumerable<Type> types = assembly
                .GetTypes()
                .Where(t => typeof(IMapDefinition).IsAssignableFrom(t))
                .Where(t => !t.IsAbstract && !t.IsInterface)
                .Where(t=> t.BaseType?.IsGenericType == true)
                .Where(t=> t.BaseType.GetGenericTypeDefinition() == typeof(BaseMap<,>));

            foreach (var type in types)
            {
                IMapDefinition instance = (IMapDefinition)Activator.CreateInstance(type)!;
                instance.ConfigureMapping(this);
            }
        }
    }
}

