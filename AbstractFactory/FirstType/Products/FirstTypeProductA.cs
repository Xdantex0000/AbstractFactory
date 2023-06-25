using AbstractFactory.Abstractions.Products;

namespace AbstractFactory.TypeA.Products
{
    class FirstTypeProductA : ProductA
    {
        public override string Name { get; } = nameof(FirstTypeProductA);
        public override string Type { get; } = "First type";
    }
}
