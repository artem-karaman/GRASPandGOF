using System;

namespace Core.Composite
{
    internal class Leaf : IComponent
    {
        internal Leaf(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public void Add(IComponent c)
        {
            throw new NotImplementedException();
        }

        public string Display()
        {
            return $"{Name} ";
        }

        public void Remove(IComponent c)
        {
            throw new NotImplementedException();
        }
    }
}
