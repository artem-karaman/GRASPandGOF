using UnityEngine;

namespace Core.Composite
{
    internal interface IComponent
    {
        public string Name { get; }
        public string Display();
        public void Add(IComponent c);
        public void Remove(IComponent c);
    }
}
