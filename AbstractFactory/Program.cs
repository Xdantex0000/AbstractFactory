using AbstractFactory.Abstractions;
using AbstractFactory.SecondType;
using AbstractFactory.TypeA;

Factory[] factories = { new FirstTypeFactory(), new SecondTypeFactory() };

foreach (var factory in factories)
{
    Console.WriteLine($"" +
        $"{factory.CreateProductA().GetDetails()}\n" +
        $"{factory.CreateProductB().GetDetails()}\n" +
        $"{factory.CreateProductC().GetDetails()}\n");
}
