using System;
using System.Reflection.Metadata;

namespace CsBases.Fundamentals;

/* Ejemplo de herencia 
- Override permite personalizar o extender el comportamiento de métodos heredados.
- Solo se puede usar si el método de la clase base está marcado como virtual, abstract o override.

public class Product {
    public virtual string GetDescription() {
        return "Descripción base";
    }
}

public class ServiceProduct : Product {
    public override string GetDescription() {
        return "Descripción sobrescrita";
    }
}
*/
public class Product : IProduct
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid UniqueCode { get; set; }

    //Constructor
    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
        CreatedAt = DateTime.Now;
        UniqueCode = Guid.NewGuid();

    }

    public void AppplyDiscount(decimal porcentage)
    {
        var discountAmount = Price * (porcentage / 100);
        Price -= discountAmount;
    }

    // La palabra reservada virtual permite que un método pueda ser sobrescrito en una clase derivada
    public virtual string GetDescription()
    {
        return $"{Name} - {Price:C}";
    }

}
class ServiceProduct : Product
{
    public int DurationInDays { get; set; }

    public ServiceProduct(string name, decimal price, int duration) : base(name, price)
    {
        DurationInDays = duration;

    }

    //Sobrescritura del método GetDescription para sobrescribrir se utiliza la palabra reservada override
    public override string GetDescription()
    {
        return $"{base.GetDescription()} - Duración: {DurationInDays}  días";
    }
}
