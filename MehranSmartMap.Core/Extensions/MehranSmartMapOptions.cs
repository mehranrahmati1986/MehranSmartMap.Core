using System.Reflection;

namespace MehranSmartMap.Core.Extensions;

public class MehranSmartMapOptions
{
    public IEnumerable<Assembly> ScanAssemblies { get; set; }
}
