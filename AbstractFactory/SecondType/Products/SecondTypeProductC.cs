using AbstractFactory.Abstractions.Products;

namespace AbstractFactory.SecondType.Products
{
    class SecondTypeProductC : ProductC
    {
        public override string Name => nameof(SecondTypeProductA);

        public override string Type => "Second type";
    }
}
