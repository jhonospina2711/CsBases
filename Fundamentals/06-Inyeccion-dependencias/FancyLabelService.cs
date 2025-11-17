using CsBases.Fundamentals;

public class FancyLabelService : ILabelService
{
    public string GenerateLabel(Product product)
    {
        return $"*** {product.Name.ToUpper()} *** | PRECIO: {product.Price:C} | ID: {product.GetHashCode()}";
    }
}
