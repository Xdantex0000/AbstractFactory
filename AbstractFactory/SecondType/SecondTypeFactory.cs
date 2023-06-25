using AbstractFactory.Abstractions;
using AbstractFactory.Abstractions.Products;
using AbstractFactory.SecondType.Products;

namespace AbstractFactory.SecondType
{
    class SecondTypeFactory : Factory
    {
        public override ProductA CreateProductA() => new SecondTypeProductA();

        public override ProductB CreateProductB() => new SecondTypeProductB();

        public override ProductC CreateProductC() => new SecondTypeProductC();
    }
}
