using AbstractFactory.Abstractions.Products;

namespace AbstractFactory.Abstractions
{
    abstract class Factory
    {
        public abstract ProductA CreateProductA();
        public abstract ProductB CreateProductB();
        public abstract ProductC CreateProductC();
    }
}
