namespace AbstractFactory.Abstractions.Products
{
    abstract class Product
    {
        public abstract string Name { get; }

        public abstract string Type { get; }

        public virtual string GetDetails() => $"Name: {Name}    Type: {Type}";
    }
}
