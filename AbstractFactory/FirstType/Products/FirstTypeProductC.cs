using AbstractFactory.Abstractions.Products;

namespace AbstractFactory.FirstType.Products
{
    class FirstTypeProductC : ProductC
    {
        public override string Name { get; } = nameof(FirstTypeProductC);
        public override string Type { get; } = "First type";
    }
}
