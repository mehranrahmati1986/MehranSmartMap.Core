using MehranSmartMap.Core.BaseMap;

namespace MehranSmartMap.Core.Samples;

public class ProductDto : BaseMap<ProductDto, Product>
{
    public int Id { get; set; }
    public string Name { get; set; }
}