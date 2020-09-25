using System;
using System.Collections.Generic;
using System.Text;

namespace TestECS
{
    class Entity
    {
        public int ID { get; set; }

        List<Component> components = new List<Component>();

        public void AddComponent(Component component)
        {
            components.Add(component);
            component.entity = this;
        }
        public T GetComponent<T>() where T : Component
        {
            foreach (Component component in components)
            {
                if (component.GetType().Equals(typeof(T)))
                {
                    return (T)component;
                }
            }
            return null;
        }
    }
}
