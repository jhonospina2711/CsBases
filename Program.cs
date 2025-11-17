using static System.Console;
using CsBases.Fundamentals;

class Program
{
    static void Main(string[] args)
    {
        var laptop = new Product("Laptop", 1200);
        //WriteLine(laptop.GetDescription());
        var soporte = new ServiceProduct("Soporte Técnico", 300, 30);
        //WriteLine(soporte.GetDescription());
        var product = new Product("Mouse Gamer", 300);
        var productDto = ProductAdapter.ToDto(product);
        // WriteLine($"{productDto.Name} - {productDto.Price:C} - Código: {productDto.Code}");

        // Inyección de dependencias
        ILabelService labelService = new LabelService();
        var mananger = new ProductMananger(labelService);
        var monitor = new Product("Monitor 4K", 100);
        var installacion = new ServiceProduct("Instalación Monitor", 20, 30);
        mananger.PrintLabel(monitor);
        mananger.PrintLabel(installacion);
        // Ejemplo usando FancyLabelService
        ILabelService fancyLabelService = new FancyLabelService();
        var fancyMananger = new ProductMananger(fancyLabelService);
        fancyMananger.PrintLabel(monitor);
        fancyMananger.PrintLabel(installacion);
    }
}
