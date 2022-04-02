namespace Core.Composite
{
    internal interface IComponent
    {
        string Name { get; }
        string Display();
        void Add(IComponent c);
        void Remove(IComponent c);
    }
}
