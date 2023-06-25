using AbstractFactory.Abstractions.Products;

namespace AbstractFactory.SecondType.Products
{
    class SecondTypeProductB : ProductB
    {
        public override string Name => nameof(SecondTypeProductB);

        public override string Type => "Second type";
    }
}
