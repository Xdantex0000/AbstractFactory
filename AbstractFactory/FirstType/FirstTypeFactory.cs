using AbstractFactory.Abstractions;
using AbstractFactory.Abstractions.Products;
using AbstractFactory.FirstType.Products;
using AbstractFactory.TypeA.Products;

namespace AbstractFactory.TypeA
{
    class FirstTypeFactory : Factory
    {
        public override ProductA CreateProductA() => new FirstTypeProductA();

        public override ProductB CreateProductB() => new FirstTypeProductB();

        public override ProductC CreateProductC() => new FirstTypeProductC();
    }
}