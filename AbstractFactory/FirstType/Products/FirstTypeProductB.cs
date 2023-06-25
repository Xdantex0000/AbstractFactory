using AbstractFactory.Abstractions.Products;

namespace AbstractFactory.FirstType.Products
{
    class FirstTypeProductB : ProductB
    {
        public override string Name { get; } = nameof(FirstTypeProductB);
        public override string Type { get; } = "First type";
    }
}
