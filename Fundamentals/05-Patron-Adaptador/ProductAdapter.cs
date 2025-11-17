using CsBases.Fundamentals;

public class ProductAdapter
{
    // Método estático para convertir Product a ProductDto
    public static ProductDto ToDto(Product product)
    {
        return new ProductDto
        {
            Name = product.Name ?? "Sin Nombre",
            Price = product.Price,
            Code = $"P-{product.Id}-{product.UniqueCode.ToString().Substring(0, 8)}"
        };
    }
}