using System.Diagnostics.CodeAnalysis;
using MutationTesting;

[ExcludeFromCodeCoverage]
class Program
{
    static void Main(string[] args)
    {
        var calculator = new PriceCalculator();
        decimal price = 100m;
        decimal discountPercent = 15m;
        decimal finalPrice = calculator.CalculatePrice(price, discountPercent);
        Console.WriteLine($"Original price: {price:C}");
        Console.WriteLine($"Discount: {discountPercent}%");
        Console.WriteLine($"Final price: {finalPrice:C}");
    }
}
