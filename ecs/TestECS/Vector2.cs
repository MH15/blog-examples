using System;
using System.Collections.Generic;
using System.Text;

namespace TestECS
{
    class Vector2
    {
        public float x = 0;
        public float y = 0;

        public static Vector2 Zero = new Vector2(0, 0);
        public static Vector2 One = new Vector2(0, 0);

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
