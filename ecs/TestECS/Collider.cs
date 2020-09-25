using System;
using System.Collections.Generic;
using System.Text;

namespace TestECS
{
    class Collider : Component
    {
        // implementation of a Collider component

        public Collider()
        {
            ColliderSystem.Register(this);
        }

    }
}
