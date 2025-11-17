using CsBases.Fundamentals;

public class ProductMananger
{
    private readonly ILabelService _labelService;

    public ProductMananger(ILabelService labelService)
    {
        _labelService = labelService;
    }

    public void PrintLabel(Product product)
    {
        var label = _labelService.GenerateLabel(product);
        WriteLine(label);
    }
}