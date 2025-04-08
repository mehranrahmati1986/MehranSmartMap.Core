using AutoMapper;

namespace MehranSmartMap.Core.Infrastructure;

public interface IMapDefinition
{
    void ConfigureMapping(Profile profile);
}