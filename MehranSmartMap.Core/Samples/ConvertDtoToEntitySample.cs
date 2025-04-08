using MehranSmartMap.Core.Extensions;

namespace MehranSmartMap.Core.Samples;

/// <summary>
/// تبدیل Dto به موجودیت
/// </summary>
public sealed class ConvertDtoToEntitySample
{
    public ConvertDtoToEntitySample()
    {
        ProductDto productDto = new() { Id = 1, Name = "Sample Product" };
        Product product = productDto.ToEntity<Product>();
        Console.WriteLine($"{product.Id} - {product.Name}");
    }
}
