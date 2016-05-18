using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserCommand
{
    public class Heroes
    {
        List<Heroes_Component> components = new List<Heroes_Component>();

        public void AddComponnet(Heroes_Component component)
        {
            components.Add(component);
        }

        public T GetComponnet<T>()
        {
            foreach (Heroes_Component com in components)
            {
                if (com.GetType() == typeof(T))
                {
                    return (T)Convert.ChangeType(com, typeof(T));
                }
            }

            return default(T);
        }
    }
}
