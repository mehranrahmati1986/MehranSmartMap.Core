using MehranSmartMap.Core.Extensions;

namespace MehranSmartMap.Core.Samples;

/// <summary>
/// تبدیل موجودیت به Dto
/// </summary>
public sealed class ConvertEntityToDtoSample
{
    public ConvertEntityToDtoSample()
    {
        Product product = new() { Id = 1, Name = "Sample Product" };
        ProductDto productDto = product.ToDto<ProductDto>();
        Console.WriteLine($"{productDto.Id} - {productDto.Name}");
    }
}
