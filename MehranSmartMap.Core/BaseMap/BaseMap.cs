using AutoMapper;
using MehranSmartMap.Core.Infrastructure;

namespace MehranSmartMap.Core.BaseMap;

public abstract class BaseMap<T, Entity> : IMapDefinition
{
    /// <summary>
    /// اگر true باشه، نگاشت دوطرفه ساخته میشه (ReverseMap)
    /// </summary>
    protected virtual bool EnableReverseMap => true;

    public void ConfigureMapping(Profile profile)
    {
        IMappingExpression<T, Entity> map = profile.CreateMap<T, Entity>();

        if (EnableReverseMap)
        {
            CustomMappings(map, map.ReverseMap());
        }
        else
        {
            CustomMappings(map, null);
        }
    }

    /// <summary>
    ///  نگاشت‌های سفارشی، فقط در صورت نیاز 
    /// </summary>
    /// <param name="mapping"></param>
    /// <param name="reversMap"></param>
    public virtual void CustomMappings(IMappingExpression<T, Entity> mapping, IMappingExpression<Entity, T> reversMap) { }
}
