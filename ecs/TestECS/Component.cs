using System;
using System.Collections.Generic;
using System.Text;

namespace TestECS
{
    class Component
    {
        public Entity entity;

        public virtual void Update(float gameTime) { }
    }
}
