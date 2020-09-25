using System;
using System.Collections.Generic;
using System.Text;

namespace TestECS
{
    class Sprite : Component
    {
        // implementation of a Collider component

        public Sprite()
        {
            SpriteSystem.Register(this);
        }

        public override void Update(float gameTime)
        {
            // We'd like to do something like this:
            Transform t = entity.GetComponent<Transform>();
            // GameEngine.DrawSprite(texture, t.position); // assume the fictitious GameEngine class
        }
    }
}
