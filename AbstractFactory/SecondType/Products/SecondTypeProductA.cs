using AbstractFactory.Abstractions.Products;

namespace AbstractFactory.SecondType.Products
{
    class SecondTypeProductA : ProductA
    {
        public override string Name { get; } = nameof(SecondTypeProductA);

        public override string Type { get; } = "Second type";
    }
}
