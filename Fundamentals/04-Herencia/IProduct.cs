using System;

namespace CsBases.Fundamentals;

public interface IProduct
{

    void AppplyDiscount(decimal porcentage);
    string GetDescription();
}
