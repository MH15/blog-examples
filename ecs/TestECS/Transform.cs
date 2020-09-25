using System;
using System.Collections.Generic;
using System.Text;

namespace TestECS
{
    class Transform : Component
    {
        public Vector2 position = Vector2.Zero;
        public Vector2 scale = Vector2.Zero;
        public float layerDepth = 0;
        public float rotation = 0;

        public Transform()
        {
            TransformSystem.Register(this);
        }



    }
}
