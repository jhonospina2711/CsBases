using CsBases.Fundamentals;

public class ProductRepository
{
    public async Task<Product> GetProduct(int id)
    {
        //Obtener de una base de datos
        //una llamada a un api externa 
        //Podria ser un archivo
        WriteLine("Buscando producto...");
        await Task.Delay(2000);
        return new Product("Producto simulado", 500);
    }
}