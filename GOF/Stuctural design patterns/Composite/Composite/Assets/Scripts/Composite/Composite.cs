using System.Collections.Generic;

namespace Core.Composite
{
    internal class Composite : IComponent
    {
        IList<IComponent> children = new List<IComponent>();

        public Composite(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public void Add(IComponent c)
        {
            children.Add(c);
        }

        public string Display()
        {
            var result = string.Empty;

            foreach (IComponent c in children)
            {
                result += c.Display();
            }

            return $"{Name} \n {result} \n";
        }

        public void Remove(IComponent c)
        {
            children.Remove(c);
        }
    }
}
